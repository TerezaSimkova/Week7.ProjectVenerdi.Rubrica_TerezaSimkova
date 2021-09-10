using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7.ProjectVenerdi.Core.Entities
{
    public class Address
    {
        public int IdAddress { get; set; }
        public string TypeOfAddress { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int CAP { get; set; }
        public string Region { get; set; }
        public string Nation { get; set; }

        //FK
        public Contact Contact { get; set; }
        public int IdContact { get; set; }

        public override string ToString()
        {
            return $"Id:{IdAddress}\t{TypeOfAddress}\t{Street}-{City}-{CAP}\t{Region}-{Nation}-{IdContact}\n";
        }
    }
}
