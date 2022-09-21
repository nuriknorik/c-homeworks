using ConsoleApp5;
using System.Text.Json;
using System.Xml.Serialization;

var money = Client.Converter("USD", "AZN", 100);
var money1 = Client.Converter("EUR", "TRY", 100);
var money2 = Client.Converter("CNY", "EUR", 100);
