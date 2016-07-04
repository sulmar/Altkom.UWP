using Altkom.Bicycle.Models;
using Altkom.Bicycle.UWPClient.Converters;
using Altkom.Bicycle.UWPClient.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.Bicycle.UWPClient.ViewModels
{
    public class PersonsViewModel : BaseViewModel
    {
        public IList<Person> Persons { get; set; }

        private IPersonsService PersonsService = new MockPersonsService();

        private Person _SelectedPerson;

        public Person SelectedPerson
        {
            get { return _SelectedPerson; }
            set
            {
                if (_SelectedPerson != value)
                {
                    _SelectedPerson = value;

                    OnPropertyChanged();
                }
            }
        }


        public PersonsViewModel()
        {
            Persons = PersonsService.GetPersons();
        }
    }
}
