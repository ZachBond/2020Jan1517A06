using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPSVehicles.EntityResources
{
    public class MakeModel
    {
        private string _Make;
        private string _Model;
        public string Make
        {
            get
            {
                return _Make;
            }
            set
            {
                if (string.IsNullOrEmpty(value)) 
                {
                    throw new Exception("Missing Make value.");
                }
                else
                {
                    _Make = value;
                }
            }

        }
        public string Model
        {
            get
            {
                return _Model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Missing Model value.");
                }
                else
                {
                    _Model = value;
                }
            }

        }
        public MakeModel(string make, string model)
        {
            Make = make;
            Model = model;
        }
        public override string ToString()
        {
            return Make + "/" + Model; 
        }
    }
}
