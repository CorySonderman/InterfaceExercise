using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InterfaceExercise
{   //In your IVehicle
    /* Create 4 members that Car, Truck, & SUV all have in common. *Done
     * Example: All vehicles have a number of wheels... for now..
     */

    public interface IVehicle
    {
        public string EngineSize { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void Drive();
       
        
        
    }
}
