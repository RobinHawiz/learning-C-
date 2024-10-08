using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstantiatedClasses
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // public int Age { get; set; }

        // private backing field
        private int _age;

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 0 && value < 126)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value", "Age needs to be in a valid range.");
                }
            }
        }

        // private backing field
        private string _ssn;

        public string SSN
        {
            get
            {
                // Swedish social security number format 123456-7891 -> 123456-****
                string output = _ssn.Substring(0, _ssn.Length - 5) + "-****";
                return output;
            }
            set
            {
                _ssn = value;
            }
        }
    }
}
