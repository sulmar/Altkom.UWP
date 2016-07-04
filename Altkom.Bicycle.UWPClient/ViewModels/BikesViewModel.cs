using Altkom.Bicycle.Models;
using Altkom.Bicycle.UWPClient.Commands;
using Altkom.Bicycle.UWPClient.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Altkom.Bicycle.UWPClient.ViewModels
{
    public class BikesViewModel : BaseViewModel
    {
        public ObservableCollection<Bike> Bikes { get; set; }

        private Bike _SelectedBike;

        public Bike SelectedBike
        {
            get { return _SelectedBike; }
            set
            {
                if (_SelectedBike != value)
                {
                    _SelectedBike = value;
                    OnPropertyChanged();
                }
            }
        }


        private IBikesService BikesService = new MockBikesService();

        public BikesViewModel()
        {
            var bikes = BikesService.GetBikes();

            Bikes = new ObservableCollection<Bike>(bikes);

            SelectedBike = Bikes.FirstOrDefault();
        }

        #region AddBikeCommand

        private ICommand _AddBikeCommand;
        public ICommand AddBikeCommand
        {
            get
            {
                if (_AddBikeCommand == null)
                {
                    _AddBikeCommand = new RelayCommand(AddBike, CanAddBike);
                }

                return _AddBikeCommand;
            }
        }

        public void AddBike()
        {
            var bike = new Bike { BikeId = 10, Model = "Romet" };
            Bikes.Add(bike);
        }

        public bool CanAddBike()
        {
            return false;
        }

        #endregion

      

      
    }
}
