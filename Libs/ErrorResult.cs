using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libs
{
    public class ErrorResult
    {

        public int ErrorResultId
        {
            get;
            set;
        }
        [Required]
        public virtual Error error { get; set; }
        public override string ToString()
        {
            return "Error\n"
                + "code: " + error.code + "\n"
                + "message: " + error.message + "\n";
        }
    }
}
