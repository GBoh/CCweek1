using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerProperties
{
    class customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value <= 0)
                {
                    Debug.Assert(value == 0, "Age cannot be younger than 0.");
                }
                _age = value;
            }
        }
    }
}
