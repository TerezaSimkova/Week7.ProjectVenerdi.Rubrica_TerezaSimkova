using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7.ProjectVenerdi.Core.Entities
{
    public class Contact
    {
        public int IdContact { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Address> addresses { get; set; } = new List<Address>();



        public override string ToString()
        {
            //string s = "";
            //for (int i=0; i<addresses.Count; i++)
            //{
            //    s += addresses[i].ToString();
            //    if (i != addresses.Count - 1)
            //    {
            //        s += " | ";
            //    }
            //}

            return $"Id:{IdContact}\t{Name} {Surname} \n"; //{s}
        }
    }
}
