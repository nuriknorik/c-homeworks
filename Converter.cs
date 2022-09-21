using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp5
{
    internal class Converter
    {
        public Query query { get; set; }
        public float result { get; set; }


        public class Query
        {
            public float amount { get; set; }
            public string from { get; set; }
            public string to { get; set; }
        }
        public override string ToString() => $"{query.from}: {query.amount} == {query.to}: {result}";
    }
}
