using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7.ProjectVenerdi.Core.Entities;

namespace Week7.ProjectVenerdi.Core.BusinessLayer
{
    public interface IBusinessLayer
    {
        public List<Contact> GetAllContacts();
        public string AddNewContact(Contact newContact);
        public string AddNewAddress(Address newAdress);
        public string DeleteContact(int idScelto);
        public List<Address> GetAllAddress();
        public string ModificaAddress(int id, string typeOfAddress);
        public string ModificaContact(int id, string nome, string cognome);
    }
}
