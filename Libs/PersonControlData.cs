using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libs
{
    public class PersonControlData
    {
        public int Id
        {
            get;
            set;
        }

        public string FileName
        {
            get;
            set;
        }

        public string FileNameShort
        {
            get;
            set;
        }

        public virtual byte[] ImageByteArray
        {
            get;
            set;
        }

        public string JsonFile
        {
            get;
            set;
        }

        public double DetectedNum
        {
            get;
            set;
        }

        public virtual ICollection<Person> PersonsList
        {
            get;
            set;
        }

        public virtual ErrorResult ErrorResult
        {
            get;
            set;
        }

        //public bool ErrorState
        //{
        //    get;
        //    set;
        //}

        public bool Result
        {
            get;
            set;
        }
    }
}
