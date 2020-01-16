using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#region Additional Namespace Requirements
using OOPSVehicles.EntityResources;
#endregion
namespace OOPSVehicles.Entities
{
    public class Aviation:Vehicle
    {
        private int _Capacity;
        private int _Range;
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
		            throw new Exception("Invalid Capacity. Value must be greater than 0");
	            }
            }
        }
        public int Range
        {
	        get{ return _Range;}
	        set
            {
	            if (value > 0)
	            {
		            _Range = value;
	            }
	            else
	            {
		            throw new Exception("Invalid Range. Value must be greater than 0");
	            }
            }
        }
        public Aviation(string serialNumber, Fuel fuelType, MakeModel makeModel, int capacity, int range) 
		                    :base(serialNumber, fuelType, makeModel)
        {
	        Capacity = capacity;
	        Range = range;
        }
        public override string ToString()
        {
            return "Serial Number " + SerialNumber + "\n" +
                   "Fuel " + FuelType + "\n" +
                   "Make/Model " + MakeModel.ToString() + "\n" +
                   "Capacity " + Capacity.ToString() + "\n" +
                   "Range (mi) " + Range.ToString() + "\n\n";

        }
    }
}

