using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.Bicycle.Models
{
    public class Rental : Base
    {        
        public int RentalId { get; set; }

        public DateTime BeginDate { get; set; }

        public Bike Bike { get; set; }

        public Station BeginStation { get; set; }

        public Person Rentee { get; set; }

        public DateTime? EndDate { get; set; }

        public Station EndStation { get; set; }


    }
}
