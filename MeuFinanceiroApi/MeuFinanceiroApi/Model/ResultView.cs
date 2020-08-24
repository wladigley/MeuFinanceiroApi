using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeuFinanceiroApi.Model
{
    public class ResultView
    {
        public bool success { get; set; }
        public string data { get; set; }
        public string error { get; set; }
        public string uriInformation { get; set; }   
    }
}
