using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany * Done

            //Create 3 classes called Car , Truck , & SUV * Done


            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class *Done
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members. *Done
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            var fordGT = new Car{Year = 2018, Make = "Ford", Model = "GT", Horsepower = 675, SportMode = true};
            var velociRaptor = new Truck {Year = 2023, Make = "Ford Hennessy", Model = "VelociRaptor", HasFourWheelDrive = true};
            var inkasSentry = new SUV {Year = 2023, Make = "Inkas", Model = "Sentry", EngineSize = "6.7l diesel", EconomyMode = false };

            var vehicles = new List<IVehicle>() {fordGT , velociRaptor, inkasSentry };
            Console.WriteLine($"Hmm... What do I want to take for a spin today?");
            Console.WriteLine();
            
            foreach (var vehicle in vehicles ) 
            { 
                
                vehicle.Drive();
                Console.WriteLine($"Year: {vehicle.Year} Make: {vehicle.Make} Model: {vehicle.Model}" );
                Console.WriteLine();
                
            }

        }
    }
}
