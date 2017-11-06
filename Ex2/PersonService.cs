using Ex1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class PersonService
    {
        private object myLock = new object();
        private IList<Person> persons = new List<Person>();

        public void AddPerson(Person p)
        {
            lock (myLock)
            {
                persons.Add(p);
            }
        }

        public IList<Person> GetPersons()
        {
            lock (myLock) { 
                return new List<Person>(persons);
            }
        }
    }
}
