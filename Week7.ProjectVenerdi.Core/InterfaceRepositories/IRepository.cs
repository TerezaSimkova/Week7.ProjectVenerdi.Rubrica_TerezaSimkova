using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7.ProjectVenerdi.Core.InterfaceRepositories
{
    public interface IRepository<T>
    {
        public List<T> GetAll(); // Visualizzare tutti i contatti
        public T Add(T item); // Aggiungere contact o indirizzo
        public bool Delete(T item); //Rimuovere
    }
}
