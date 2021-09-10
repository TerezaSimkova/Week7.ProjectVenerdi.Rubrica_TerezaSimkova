using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7.ProjectVenerdi.Core.Entities;
using Week7.ProjectVenerdi.Core.InterfaceRepositories;

namespace Week7.ProjectVenerdi.RepoEF
{
    public class RepositoryAddressEF : IAddressRepository
    {
        private readonly RubricaContext rct;

        public RepositoryAddressEF()
        {
            rct = new RubricaContext();
        }
        public Address Add(Address address)
        {
            rct.Addresses.Add(address);
            rct.SaveChanges();
            return address;
        }

        public bool Delete(Address address)
        {
            rct.Addresses.Remove(address);
            rct.SaveChanges();
            return true;
        }

        public List<Address> GetAll()
        {
            return rct.Addresses.ToList();
        }

        public Address GetById(int idAddress)
        {
            return rct.Addresses.FirstOrDefault(a => a.IdContact == idAddress);
        }
    }
}
