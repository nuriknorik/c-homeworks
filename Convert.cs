
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Client
    {
        public const string _key = "P4UwunHfmFXlLEpF2rSiQ1vtp1WeobCi";
        public const string _url = @"https://api.apilayer.com/exchangerates_data/convert?";
        public static Converter Converter(string first ,string second , float count)
        {
            var client = new WebClient();
            var Downoload = client.DownloadString($"{_url}apikey={_key}&to={first}&from={second}&amount={count}");
            throw new NullReferenceException();
        }
    }
}