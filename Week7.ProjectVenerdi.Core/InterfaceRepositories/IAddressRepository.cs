using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7.ProjectVenerdi.Core.Entities;

namespace Week7.ProjectVenerdi.Core.InterfaceRepositories
{
    public interface IAddressRepository : IRepository<Address>
    {
        public Address GetById(int idAddress);
    }
}
