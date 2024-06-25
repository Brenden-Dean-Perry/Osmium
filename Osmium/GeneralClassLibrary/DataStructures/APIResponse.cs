using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLibrary.DataStructures
{
    public class APIResponse
    {
        public string Ticker { get; set; } 
        public string Field { get; set; }
        public string Value { get; set; }
        public APIResponse()
        {

        }
    }
}
