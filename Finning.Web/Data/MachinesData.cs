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
                    /*First I wrote some Java code to show how I would change the dateTime to the standard format:
                     import java.util.*;
                    import java.text.*;

                    public class DateReFormat {
                        public static void main(String args[]) {
    	
    	                    final String old_format = "yyy/MM/dd";
    	                    final String new_format = "dd/MM/yyyy";

    	                    String oldDateString = "2017/01/01";
    	                    String newDateString = "01/01/2017;

    	                    SimpleDateFormat sdf = new SimpleDateFormat(old_format);
    	                    Date d = sdf.parse(oldDateString);
    	                    sdf.applyPattern(new_format);
    	                    newDateString = sdf.format(d);

                    Once I had the pseudo code and the java version complete, I then changed my code into C#:

                    namespace Finning.Web.Data {
	                DateTime dt = new DateTime (2017, 01, 01);
		                console.Write("\nShort Date: {0.D}", dt);
                    }

                    This C# code creates a new DateTime object and displays the value of the new DateTime object. As I am new to learning C#, I 
                    didn't think it was a good idea altering the code as I am unfamilar with .NET framework and therefore didn't want to cause any
                    runtime or compile errors; however this is the C# I learnt which I would have included in this file (MachinesData.cs).
        */
                    Description = "SMALL WHEEL LOADER",
                    SerialNumber = "CAT123456",
                    YearOfManufacture = 2016,
                    // include the variable initialised in "LocationsData.cs" so when the user selects the location of the machine, it calls and retrieves
                    //the correct specific location from the cordinates (Lantitude and Longitude)
                     
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
