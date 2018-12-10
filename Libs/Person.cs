using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libs
{
    public class Person
    {
        [Key]
        public int PersonId
        {
            get;
            set;
        }
        public string faceId { get; set; }
        [Required]
        public virtual FaceRectangle faceRectangle { get; set; }
        [Required]
        public virtual FaceAttributes faceAttributes { get; set; }
        public override string ToString()
        {
            return "Person: \n"
                + "faceId: " + faceId + "\n"
                + faceRectangle.ToString() + faceAttributes.ToString();
        }
    }
}
