using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    //a class represents the define characteristics of an item 
    // an item can be physical thing (ex. Cell Phone), concept (student),
    //  collection of data
    //visual studio creates your class without a specified access type 
    //default type for a class is private
    // code outside of a private class cannot use the contents of the private class
    // for the class to be used by an outside user, it must be public
    public class Window
    {
        //the class can have data that is open to the user by
        //  defining it as apublic datatype variable name
        //the class can have data that is restricted from the user 
        //  by defining it as a private datatype variable name
        //the class can create a property that can be used to
        //  interface between the user and the private data
        //the property will have public access

        //Private Data Member 
        private string _Manufacturer;

        //Properties
        //implemented in 2 ways
        //A) Fully Implemented Property
        //      used because there is additional code/logic used in proccressing data
        //B) Auto Implemented Property
        //      used when no need for additional code/logic,
        //      when the data is simply saved
        public string Manufacturer
        {
            //assume the Manufacturer is nullable string 
            //3 possibilities 
            //A) there are characters
            //B) string has no data
            //C) there is a physical string but, no characters
            // there will be additional code to ensure only A and B 
            //  exist for the data 
            // this requires a private data member to hold the data 
            //  and a property to manage the data content

            get
            {
                //returns data via the property to the outside user
                //   of the property
                return _Manufacturer;
            }

            set
            {
                //the set takes incoming data and places that data into the private data member

            }
        }
    }
}
