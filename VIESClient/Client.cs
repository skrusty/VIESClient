using System;
using System.Diagnostics;
using VIESClient.SoapEndpoint;

namespace VIESClient
{
    public class Client
    {
        public VIESResponse CheckVATNumber(string countryCode, string vatNumber)
        {
            var vClient = new checkVatPortTypeClient();
            var isValid = false;
            try
            {
                string name;
                string address;
                vClient.checkVat(ref countryCode, ref vatNumber, out isValid, out name, out address);
                return new VIESResponse
                {
                    IsValid = isValid,
                    Name = name,
                    Address = address,
                    CountryCode = countryCode,
                    VATNumber = vatNumber
                };
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"VIES threw an exception {ex.Message}");
                return new VIESResponse
                {
                    IsValid = isValid,
                    CountryCode = countryCode,
                    VATNumber = vatNumber
                };
            }
        }
    }

    public class VIESResponse
    {
        public bool IsValid { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string CountryCode { get; set; }
        public string VATNumber { get; set; }
    }
}