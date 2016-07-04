using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.Bicycle.Models
{
    public class Station : Base
    {
        public int StationId { get; set; }

        #region StationName

        private string _StationName;
        public string StationName
        {
            get
            {
                return _StationName;
            }

            set
            {
                _StationName = value;
                OnPropertyChanged();
            }
        }

        #endregion

        public string Address { get; set; }

        public Location Location { get; set; }

        public Station()
        {

        }

        public override string ToString()
        {
            return $"{StationName} {Address}";
        }

    }
}
