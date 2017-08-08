using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finning.Web.Models;

namespace Finning.Web.Data
{
    public static class LocationsData
    {
        public static List<Location> Get()
        {
            return new List<Location>
            {
                new Location
                {
                    Name = "Sheffield",
                    Latitude = 53.383055,
                    Logitude = -1.464795,
                    NumberOfMachines = 25
                    //create a variable which would be placed in "MachinesData.cs" to link both the files together.
                },
                new Location
                {
                    Name = "Cornwall",
                    Latitude = 50.322669,
                    Logitude = -5.019579,
                    NumberOfMachines = 50
                },
                new Location
                {
                    Name = "Liverpool",
                    Latitude = 53.410777,
                    Logitude = -2.9778385,
                    NumberOfMachines = 10
                }
            };
        }
    }
}
