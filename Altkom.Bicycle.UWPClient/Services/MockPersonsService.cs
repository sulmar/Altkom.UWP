using Altkom.Bicycle.UWPClient.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Altkom.Bicycle.Models;

namespace Altkom.Bicycle.UWPClient.Services
{
    public class MockPersonsService : IPersonsService
    {

        private IList<Person> _Persons = new List<Person>
        {
            new Person { FirstName = "Marcin", LastName = "Sulecki" },
            new Person { FirstName = "Jan", LastName = "Kowalski" },
            new Person { FirstName = "Anna", LastName = "Kowalska" },
        };


        public IList<Person> GetPersons()
        {
            return _Persons;
        }
    }
}
