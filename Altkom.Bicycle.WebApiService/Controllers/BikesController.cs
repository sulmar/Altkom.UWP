using Altkom.Bicycle.DAL;
using Altkom.Bicycle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Altkom.Bicycle.WebApiService.Controllers
{
    public class BikesController : ApiController
    {

        public IList<Bike> Get()
        {
            using (var context = new BicycleContext())
            {
                // context.Database.SqlQuery<Bike>("select * from dbo.Bikes");

                var bikes = context.Bikes.ToList();

                return bikes;
            }                

        }
    }
}
