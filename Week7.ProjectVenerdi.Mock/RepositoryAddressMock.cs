using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7.ProjectVenerdi.Core.Entities;
using Week7.ProjectVenerdi.Core.InterfaceRepositories;

namespace Week7.ProjectVenerdi.Mock
{
    public class RepositoryAddressMock : IAddressRepository
    {
        public static List<Address> addresses = new List<Address>();

        public Address Add(Address address)
        {
            if (addresses.Count == 0)
            {
                address.IdContact = 1;
            }
            else
            {
                address.IdAddress = addresses.Max(a => a.IdAddress) + 1;
            }

            var asAddress = RepositoryContactMock.contacts.FirstOrDefault(c => c.IdContact == address.IdContact);
            address.Contact = asAddress;
            asAddress.addresses.Add(address);

            addresses.Add(address);
            return address;
        }

        public bool Delete(Address item)
        {
            throw new NotImplementedException();
        }

        public List<Address> GetAll()
        {
            return addresses;
        }

        public Address GetById(int idAddress)
        {
            return addresses.FirstOrDefault(a => a.IdAddress == idAddress);
        }

    }
}
