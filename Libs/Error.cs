using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libs
{
    public class Error
    {
        public int ErrorId
        {
            get;
            set;
        }
        public string code { get; set; }
        public string message { get; set; }
    }
}
