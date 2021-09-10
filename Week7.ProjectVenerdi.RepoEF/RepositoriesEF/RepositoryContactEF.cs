using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7.ProjectVenerdi.Core.Entities;
using Week7.ProjectVenerdi.Core.InterfaceRepositories;

namespace Week7.ProjectVenerdi.RepoEF
{
    public class RepositoryContactEF : IContactRepository
    {

        private readonly RubricaContext rct;

        public RepositoryContactEF()
        {
            rct = new RubricaContext();
        }
        public Contact Add(Contact contact)
        {
            rct.Contacts.Add(contact);
            rct.SaveChanges();
            return contact;
        }

        public bool Delete(Contact contact)
        {
            rct.Contacts.Remove(contact);
            rct.SaveChanges();
            return true;
        }

        public List<Contact> GetAll()
        {
            return rct.Contacts.ToList();
        }

        public Contact GetById(int idContact)
        {
            return rct.Contacts.FirstOrDefault(c => c.IdContact == idContact);
        }
    }
}
