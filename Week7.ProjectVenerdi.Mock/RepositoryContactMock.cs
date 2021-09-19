using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7.ProjectVenerdi.Core.Entities;
using Week7.ProjectVenerdi.Core.InterfaceRepositories;

namespace Week7.ProjectVenerdi.Mock
{
    public class RepositoryContactMock : IContactRepository
    {

        public static List<Contact> contacts = new List<Contact>()
        {
            new Contact{IdContact = 1,Name = "Alessandro",Surname ="Rossi"},
            new Contact{IdContact = 2,Name = "Tereza",Surname ="Luna"},
        };

        public Contact Add(Contact contact)
        {
           
            contacts.Add(contact);
            return contact;
        }

        public bool Delete(Contact contact)
        {
            contacts.Remove(contact);
            return true;
        }

        public List<Contact> GetAll()
        {
            return contacts;
        }

        public Contact GetById(int idContact)
        {
            return contacts.FirstOrDefault(c => c.IdContact == idContact);
        }

        public Contact Update(Contact contattoEsistente)
        {
            var oldContact = contacts.FirstOrDefault(c => c.IdContact == contattoEsistente.IdContact);
            oldContact.Name = contattoEsistente.Name;
            oldContact.Surname = contattoEsistente.Surname;
            return contattoEsistente;
        }
    }
}
