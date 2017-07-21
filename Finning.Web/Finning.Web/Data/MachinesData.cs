using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Finning.Web.Models;

namespace Finning.Web.Data
{
    public static class MachinesData
    {
        public static List<Machine> Get()
        {
            return new List<Machine>
            {
                new Machine
                {
                    Code = "A1",
                    DeliveryDate = new DateTime(2017, 01,01),
                    Description = "SMALL WHEEL LOADER",
                    SerialNumber = "CAT123456",
                    YearOfManufacture = 2016
                },new Machine
                {
                    Code = "B1",
                    DeliveryDate = new DateTime(2016, 06, 01),
                    Description = "EXCAVATORS WHEELED",
                    SerialNumber = "CAT987654",
                    YearOfManufacture = 2016
                },
                new Machine
                {
                    Code = "C1",
                    DeliveryDate = new DateTime(2016, 01,01),
                    Description = "SKID STEER LOADER",
                    SerialNumber = "CAT248157",
                    YearOfManufacture = 2015
                }
            };
        }
    }
}
