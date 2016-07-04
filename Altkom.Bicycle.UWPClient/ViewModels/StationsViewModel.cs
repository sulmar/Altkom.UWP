using Altkom.Bicycle.Models;
using Altkom.Bicycle.UWPClient.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.Bicycle.UWPClient.ViewModels
{
    public class StationsViewModel : BaseViewModel
    {
        #region Stations

        private IList<Station> _Stations;
        public IList<Station> Stations
        {
            get
            {
                return _Stations;
            }

            set
            {
                _Stations = value;

                OnPropertyChanged();
            }
        }

        #endregion

        private Station _SelectedStation;

        public Station SelectedStation
        {
            get { return _SelectedStation; }
            set
            {
                if (_SelectedStation != value)
                {
                    _SelectedStation = value;

                    OnPropertyChanged();

                    // OnPropertyChanged(nameof(SelectedStation));
                }
            }
        }

        public Station SelectedStation1
        {
            get
            {
                return _SelectedStation;
            }

            set
            {
                _SelectedStation = value;
            }
        }

        private readonly IStationsService _stationsService;

        public StationsViewModel()
        {
            _stationsService = new RestApiStationsService();            
        }

        public async Task LoadAsync()
        {
            Stations = await _stationsService.GetStationsAsync();

            SelectedStation = Stations.FirstOrDefault();
        }
    }
}
