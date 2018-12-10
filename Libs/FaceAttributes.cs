using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libs
{
    public class FaceAttributes
    {
        public int FaceAttributesId
        {
            get;
            set;
        }
        public string gender { get; set; }
        public double age { get; set; }
        public override string ToString()
        {
            return "faceAttributes\n"
                + "gender: " + gender + "\n"
                + " age: [" + age.ToString() + "]\n";
        }
    }
}
