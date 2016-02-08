using System;
using System.Diagnostics;
using VISEClient.SoapEndpoint;

namespace VISEClient
{
    public class Client
    {
        public VISEResponse CheckVATNumber(string countryCode, string vatNumber)
        {
            var vClient = new checkVatPortTypeClient();
            var isValid = false;
            try
            {
                string name;
                string address;
                vClient.checkVat(ref countryCode, ref vatNumber, out isValid, out name, out address);
                return new VISEResponse()
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
                Debug.WriteLine($"VISE threw an exception {ex.Message}");
                return new VISEResponse()
                {
                    IsValid = isValid,
                    CountryCode = countryCode,
                    VATNumber = vatNumber
                };
            }
        }
    }

    public class VISEResponse
    {
        public bool IsValid { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string CountryCode { get; set; }
        public string VATNumber { get; set; }
    }
}
