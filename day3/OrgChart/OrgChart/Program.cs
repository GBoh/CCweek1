using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrgChart
{
    interface IEmployee
    {
        int Underlings { get; set; }
    }

    class Bill : IEmployee
    {
        public int Underlings { get; set; }
    }

    class Sam : IEmployee
    {
        public int Underlings { get; set; }
    }

    class Fred : IEmployee
    {
        public int Underlings { get; set; }
    }

    class Jane : IEmployee
    {
        public int Underlings { get; set; }
    }

    class Alice : IEmployee
    {
        public int Underlings { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var CEO = new Bill();
        }
    }
}
