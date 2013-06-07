using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp1.Models
{
    public class Address
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public int Zip1 { get; set; }
        public int Zip2 { get; set; }
        public string StateCode { get; set; }
        public string City { get; set; }
    }
}
