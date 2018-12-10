using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libs
{
    public class FaceRectangle
    {
        public int FaceRectangleId
        {
            get;
            set;
        }
        public double top { get; set; }
        public double left { get; set; }
        public double width { get; set; }
        public double height { get; set; }
        public override string ToString()
        {
            return "faceRectangle\n " +
                " top: [" + top.ToString() + "]\n"
                + " left: [" + left.ToString() + "]\n"
                + " width: [" + width.ToString() + "]\n"
                + " height: [" + height.ToString() + "]\n";
        }
    }
}
