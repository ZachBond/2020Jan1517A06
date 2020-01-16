using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#region Additional Namespace Requirements
using OOPSVehicles.EntityResources;
#endregion
namespace OOPSVehicles.Entities
{
    public class Vehicle
    {
        private string _SerialNumber;
        private Fuel _FuelType;
        private MakeModel _MakeModel;
        public string SerialNumber
        {
            get
            {
	            return _SerialNumber;
            }
             set
            {
	            _SerialNumber = value;
            }
        }
        public Fuel FuelType
        {
            get
            {
            return _FuelType;
            }
            set
            {
	            _FuelType = value;
            }
        }
        public MakeModel MakeModel
        {
            get
            {
                return _MakeModel;
            }
            set
            {
                _MakeModel = value;
            }
        }
        public Vehicle(string serialNumber, Fuel fuelType, MakeModel makeModel)
        {
	        SerialNumber = serialNumber;
	        FuelType = fuelType;
	        MakeModel = makeModel;
        }
        public Vehicle()
        {
	        SerialNumber = "";
	        FuelType = Fuel.Unleaded;
            _MakeModel = new MakeModel("Unknown", "Unknown");
        }
        public override string ToString()
        {
            return "Serial Number " + SerialNumber + "\n" +
                   "Fuel " + FuelType + "\n" +
                   "Make/Model " + MakeModel +  "\n\n";
        }


    }
}
