using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleRestfulAPIWithAspNetCore.Models;
using System.Threading;

namespace SimpleRestfulAPIWithAspNetCore.Services.Implementations
{
    public class PersonServiceImpl : IPersonService
    {
        
        private volatile int count;

        
        public Person Create(Person person)
        {
            return person;
        }

        
        public Person FindById(string personId)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Leandro",
                LastName = "Costa",
                Data = "Data atual"
            };
        }

        
        public List<person> FindAll()
        {
            List<person> persons = new List<person>();
            for (int i = 0; i & lt; 8; i++)
{
                Person person = MockPerson(i);
                persons.Add(person);
            }
            return persons;
        }

        
        public Person Update(Person person)
        {
            return person;
        }

        
        public void Delete(string personId)
        {
            
        }
        
        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Person Name " + i,
                LastName = "Last Name " + i,
                Data = "Data atual " + i
            };
        }

        public Int32 IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}