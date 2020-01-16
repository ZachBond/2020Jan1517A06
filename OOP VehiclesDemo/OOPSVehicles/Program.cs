using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#region Additional Namespace Requirements
using OOPSVehicles.Entities;
using OOPSVehicles.EntityResources;
#endregion

namespace OOPSVehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare an object reference (variable)
            MakeModel makemodel;
            //Instantiate a MakeModel object
            makemodel = new MakeModel("GMC", "Cobalt");

            //declare/assign Car object (sub class of base class Vehicle)
            Car myCar = new Car("13GM9C89", Fuel.Unleaded, makemodel, 5, 4);
            Console.WriteLine(myCar.ToString());

            //A Car is a Vehicle (a base class can hold a reference to a sub class)
            Vehicle myVehicle = new Car("13GM9C89", Fuel.Unleaded, makemodel, 5, 4);
            //to test for validation, replace the 4 with a 7 (in the line above) and re run
            Console.WriteLine(myVehicle.ToString());

            //one can create a based class instance
            Vehicle mySlowCar = new Vehicle("13GM9C89", Fuel.Unleaded, makemodel);
            Console.WriteLine(mySlowCar.ToString());
            //reassign a variable to an instance of a sub class
            mySlowCar = new Car("25FD4TR654", Fuel.Unleaded, makemodel, 6, 4);
            Console.WriteLine(mySlowCar.ToString());

            Service myServiceVehicle = new Service("4678TY768", Fuel.Diesel, 
                    new MakeModel("GMC","3500"), 10000, "lbs");
            Console.WriteLine(myServiceVehicle.ToString());

            Console.ReadLine();
        }
    }
}
