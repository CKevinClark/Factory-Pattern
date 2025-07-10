using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {

        public static IVehicle CreateVehicle(int wheelcount) 
        {
            switch (wheelcount)
            {

                case 2:
                    return new Motorcylce();

                case 4:
                    return new Car();

                case 18: 
                    return new BigRig();

                default:
                    return new Car(); 

            }
        }

    }
}
