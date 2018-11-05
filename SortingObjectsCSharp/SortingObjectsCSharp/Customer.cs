using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingObjectsCSharp
{
    class Customer
    {
        public Customer(string fname, string sname, DateTime dob)
        {
            Fname = fname;
            Sname = sname;
            Dob = dob;
        }

        public string Fname { get; set; }
        public string Sname { get; set; }
        public DateTime Dob { get; set; }
    }
}
