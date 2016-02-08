# VIESClient
A client wrapper for the SOAP interface to VIES the EU VAT Checker located at
http://ec.europa.eu/taxation_customs/vies/

## Example Usage
```c#
var client = new Client();
Console.Write("Enter Country Code (e.g. GB): ");
var countryCode = Console.ReadLine();
Console.Write("Enter VAT Number: ");
var vatNumber = Console.ReadLine();
var result = client.CheckVATNumber(countryCode, vatNumber);

Console.WriteLine($"Check returned {result.IsValid}");
Console.WriteLine($"Company: {result.Name}");
Console.WriteLine($"Address: {result.Address}");
```
