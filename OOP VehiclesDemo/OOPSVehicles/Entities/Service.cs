using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#region Additional Namespace Requirements
using OOPSVehicles.EntityResources;
#endregion
namespace OOPSVehicles.Entities
{
    public class Service:Vehicle
    {
        private decimal _TowLimit;
        public decimal TowLimit
        {
            get{ return _TowLimit;}
	        set
            {
	            if (value > 0)
	            {
		            _TowLimit = value;
	            }
	            else
	            {
		            throw new Exception("Invalid TowLimit. Value must be greater than 0");
	            }

            }
        }
        public string TowMeasure { get; private set; } //AutoImplementedProperty
        public Service(string serialNumber, Fuel fuelType, MakeModel makeModel, 
                                decimal towLimit, string towMeasure) 
		                        :base(serialNumber, fuelType, makeModel)
        {
	        TowLimit = towLimit;
	        TowMeasure = towMeasure;
        }

        public override string ToString()
        {
            return  base.ToString() + "\n" +
                   "Tow Limit " + TowLimit.ToString() + "\n" +
                   "Tow Measure " + TowMeasure + "\n\n";
        }
    }
}
