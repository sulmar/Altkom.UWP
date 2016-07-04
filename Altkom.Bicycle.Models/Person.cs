using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom.Bicycle.Models
{

    
    public class Person : Base
    {
        public int PersonId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EyeColor { get; set; }

        //public string FullName
        //{
        //    get
        //    {
        //        // return String.Format("{0} {1}", FirstName, LastName);
        //        // C# 6.0
        //        return $"{FirstName} {LastName}";
        //    }
        //}

        // C# 6.0
        public string FullName => $"{FirstName} {LastName}";
    }
}
