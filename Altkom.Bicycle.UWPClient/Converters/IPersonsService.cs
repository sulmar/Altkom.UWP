using Altkom.Bicycle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.Bicycle.UWPClient.Converters
{
    public interface IPersonsService
    {
        IList<Person> GetPersons();
    }
}
