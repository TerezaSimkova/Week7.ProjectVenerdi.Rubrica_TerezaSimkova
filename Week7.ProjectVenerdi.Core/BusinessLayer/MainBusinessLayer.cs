using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week7.ProjectVenerdi.Core.Entities;
using Week7.ProjectVenerdi.Core.InterfaceRepositories;

namespace Week7.ProjectVenerdi.Core.BusinessLayer
{
    public class MainBusinessLayer : IBusinessLayer
    {
        private readonly IContactRepository contactRepo;
        private readonly IAddressRepository addressRepo;

        public MainBusinessLayer(IContactRepository contactRepository, IAddressRepository addressRepository)
        {
            contactRepo = contactRepository;
            addressRepo = addressRepository;
        }

        public string AddNewAddress(Address newAdress)
        {
            var addressEsistente = addressRepo.GetById(newAdress.IdAddress);
            if (addressEsistente != null)
            {
                return "Errore: Id già esiste!\n";
            }
            else
            {
                addressRepo.Add(newAdress);
                return "L'ndirizzo aggiunto con successo!\n";
            }
        }

        public string AddNewContact(Contact newContact)
        {
            var contattoEsistente = contactRepo.GetById(newContact.IdContact);
            if (contattoEsistente != null)
            {
                return "Errore: Id già esiste!\n"; 
            }
            else
            {
                contactRepo.Add(newContact);
                return "Contatto aggiunto con successo!\n";
            }
        }

        public string DeleteContact(int idScelto)
        {
            Contact contattoEsistente = contactRepo.GetById(idScelto);
            if (contattoEsistente == null)
            {
                return "Errore: Id sbagliato!.\n";
            }

            var IndirizziAssociatoAlContatto = GetAllAddress().FirstOrDefault(a => a.IdContact == contattoEsistente.IdContact);
            if (IndirizziAssociatoAlContatto != null)
            {
                return "Impossibile cancellare il contatto perchè risulta che contiene almeno un indirizzo!\n";
            }
            contactRepo.Delete(contattoEsistente);
            return "Contatto eliminato correttamente!\n";

        }

        public List<Address> GetAllAddress()
        {
            return addressRepo.GetAll();
        }

        public List<Contact> GetAllContacts()
        {
            return contactRepo.GetAll();         
        }

        public string ModificaAddress(int id,string typeOfAddress)
        {
            var addressEsistente = addressRepo.GetById(id);
            if (addressRepo == null)
            {
                return "Non esiste un indirizzo con questo ID!";
            }
            else
            {
                addressEsistente.TypeOfAddress = typeOfAddress;
                addressRepo.Update(addressEsistente);
                return "L'indirizzo e stato modificato con successo!";
            }
        }

        public string ModificaContact(int id, string nome, string cognome)
        {
            var contattoEsistente = contactRepo.GetById(id);
            if (contactRepo == null)
            {
                return "Non esiste un contatto con questo ID!";
            }
            else
            {
                contattoEsistente.Name = nome;
                contattoEsistente.Surname = cognome;
                contactRepo.Update(contattoEsistente);
                return "Contatto e stato modificato con successo!";
            }
        }
    }
}
