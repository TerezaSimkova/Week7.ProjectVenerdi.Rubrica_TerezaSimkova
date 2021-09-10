using System;
using Week7.ProjectVenerdi.Core.BusinessLayer;
using Week7.ProjectVenerdi.Core.Entities;
//using Week7.ProjectVenerdi.Mock;
using Week7.ProjectVenerdi.RepositoryEF;

namespace Week7.ProjectVenerdi.Rubrica
{
    internal class Start
    {
        //Repository MOCK
        //private static readonly IBusinessLayer bl = new MainBusinessLayer(new RepositoryContactMock(),new RepositoryAddressMock());

        //Repository EF
        private static readonly IBusinessLayer bl = new MainBusinessLayer(new RepositoryContactEF(),new RepositoryAddressEF());

        internal static void Menu()
        {
            Console.WriteLine("****** Benvenuti *****\n");

            bool continua = true;
            while (continua)
            {
                Console.WriteLine("1. Visualizza tutti i contatti:");
                Console.WriteLine("2. Aggiungi un nuovo contatto:");
                Console.WriteLine("3. Aggiungi un nuovo l'indirizzo:");
                Console.WriteLine("4. Elimina un contatto:");

                Console.WriteLine("\n0. Per uscire.\n");

                int scelta;
                do
                {
                    Console.WriteLine("Cosa scegli di fare?\n");

                } while (!int.TryParse(Console.ReadLine(), out scelta) || scelta < 0 || scelta > 4);

                switch (scelta)
                {
                    case 1:
                        ShowContacts();
                        break;
                    case 2:
                        AddContact();
                        break;
                    case 3:
                        AddAddress();
                        break;
                    case 4:
                        DeleteContact();
                        break;
                    case 0:
                        continua = false;
                        Console.Write("*** Arrivederci ***");
                        break;
                }
            }
        }

        private static void DeleteContact()
        {
            ShowContacts();
            int idScelto;
            do
            {
                Console.Write("Chi vorresti eliminare dalla rubrica? Scegli ID:\n");

            } while (!int.TryParse(Console.ReadLine(), out idScelto));

            var conferma = bl.DeleteContact(idScelto);
            Console.WriteLine(conferma);
        }

        private static void AddAddress()
        {
            String typeAddress = String.Empty;
            String street = String.Empty;
            String city = String.Empty;
            String region = String.Empty;
            String nation = String.Empty;
            int cap;

            do
            {
                Console.Write("Inserisci il tipo di l'indirizzo: Domicilio / Residenza:\n");
                typeAddress = Console.ReadLine();

            } while (String.IsNullOrEmpty(typeAddress));
            do
            {
                Console.Write("Inserisci il nome della via:\n");
                street = Console.ReadLine();

            } while (String.IsNullOrEmpty(street));
            do
            {
                Console.Write("Inserisci il nome della cità:\n");
                city = Console.ReadLine();

            } while (String.IsNullOrEmpty(city));
            do
            {
                Console.Write("Inserisci la regione:\n");
                region = Console.ReadLine();

            } while (String.IsNullOrEmpty(region));
            do
            {
                Console.Write("Inserisci la nazione:\n");
                nation = Console.ReadLine();

            } while (String.IsNullOrEmpty(nation));
            do
            {
                Console.Write("Inserisci il CAP:\n");

            } while (!int.TryParse(Console.ReadLine(), out cap));

            ShowContacts();
            int idScelto;
            do
            {
                Console.Write("A quale contatto vuoi asocciare l'indirizzo? Scegli ID:\n");

            } while (!int.TryParse(Console.ReadLine(), out idScelto));

            Address newAdress = new Address()
            {
                TypeOfAddress = typeAddress,
                Street = street,
                City = city,
                Region = region,
                Nation = nation,
                CAP = cap,
                IdContact = idScelto
            };

            var conferma = bl.AddNewAddress(newAdress);
            Console.WriteLine(conferma);
        }

        private static void AddContact()
        {
            String name = String.Empty;
            String surname = String.Empty;

            do
            {
                Console.WriteLine("Inserisci il nome:");
                name = Console.ReadLine();

            } while (String.IsNullOrEmpty(name));

            do
            {
                Console.WriteLine("Inserisci il cognome:");
                surname = Console.ReadLine();

            } while (String.IsNullOrEmpty(surname));

            Contact newContact = new Contact()
            {
                Name = name,
                Surname = surname
            };

            var conferma = bl.AddNewContact(newContact);
            Console.WriteLine(conferma);
        }

        private static void ShowContacts()
        {
            var contacts = bl.GetAllContacts();
            if (contacts.Count == 0)
            {
                Console.WriteLine("Non ci sono contatti da visualizzare!");
            }
            else
            {
                foreach (var c in contacts)
                {
                    Console.WriteLine(c.ToString());
                }
            }
            
        }
    }
}