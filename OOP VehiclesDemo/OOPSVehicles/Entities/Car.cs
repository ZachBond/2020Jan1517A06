using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#region Additional Namespace Requirements
using OOPSVehicles.EntityResources;
#endregion
namespace OOPSVehicles.Entities
{
    public class Car:Vehicle
    {
        private int _Capacity;
        private int _Doors;
        public int Capacity
        {
	        get{ return _Capacity;}
	        set
            {
	            if (value > 0)
	            {
		            _Capacity = value;
	            }
	            else
	            {
		            throw new Exception("Invalid capacity. Value must be in range of 1-8");
	            }
            }
        }
        public int Doors
        {
	        get{ return _Doors;}
	        set
            {
	            if ((value == 2) || (value == 4) || (value == 5))
	            {
		            _Doors = value;
	            }
	            else
	            {
		            throw new Exception("Invalid Doors. Value must be in range of 2,4,5.");
	            }
            }

        }
        public Car(string serialNumber, Fuel fuelType, MakeModel makemodel, 
                            int capacity, int doors) 
		                :base(serialNumber, fuelType, makemodel)
        {
	        Capacity = capacity;
	        Doors = doors;
        }

        public override string ToString()
        {
            return "Serial Number " + SerialNumber + "\n" +
                   "Fuel " + FuelType + "\n" +
                   "Make/Model " + MakeModel.ToString() + "\n" +
                   "Seating " + Capacity.ToString() + "\n" +
                   "Doors " + Doors.ToString() + "\n\n";
        }
    }
}
