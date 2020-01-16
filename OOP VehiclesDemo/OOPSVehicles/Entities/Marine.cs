using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#region Additional Namespace Requirements
using OOPSVehicles.EntityResources;
#endregion
namespace OOPSVehicles.Entities
{
    public class Marine:Vehicle
    {
        public string Engine{get;set;}
        private int _Capacity;
        private int _FootLength;
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
        public int FootLength
        {
	        get{ return _FootLength;}
	        set
            {
	            if (value > 0)
	            {
		            _FootLength = value;
	            }
	            else
	            {
		            throw new Exception("Invalid FootLength. Value must be greater than 0");
	            }
            }
        }
        public Marine(string serialNumber, Fuel fuelType, MakeModel makeModel, 
                                int capacity, int footlength, string engine) 
		                        :base(serialNumber, fuelType, makeModel)
        {
	        Capacity = capacity;
	        FootLength = footlength;
            Engine = Engine;
        }
        public override string ToString()
        {
            return "Serial Number " + SerialNumber + "\n" +
                   "Fuel " + FuelType + "\n" +
                   "Make/Model " + MakeModel.ToString() + "\n" +
                   "Capacity " + Capacity.ToString() + "\n" +
                   "Length (ft) " + FootLength.ToString() + "\n" +
                   "Engine " + Engine + "\n\n";
        }
    }
}
