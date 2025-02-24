﻿using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //DONE

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            
            CarLot carLot = new CarLot();            // DJ & Amorris suggestion


            //Dot Notation
            Car Car1 = new Car();
            Car1.Year = 2018;
            Car1.Make = "Ford";
            Car1.Model = "Mustang";
            Car1.EngineNoise = "Loud";
            Car1.HonkNoise = "Loud";
            Car1.IsDriveable = "Yes";
            Console.WriteLine($"The {Car1.Model} has the following characteristics...");
            Car1.MakeEngineNoise(Car1.EngineNoise);
            Car1.MakeHonkNoise(Car1.HonkNoise);
            carLot.ListOfCars.Add(Car1);             // DJ & Amorris suggestion
            Console.WriteLine();




            Car Car2 = new Car();
            Car2.Year = 2022;
            Car2.Make = "Nissan";
            Car2.Model = "Versa";
            Car2.EngineNoise = "Soft";
            Car2.HonkNoise = "Soft";
            Car2.IsDriveable = "Yes";
            Console.WriteLine($"The {Car2.Model} has the following characteristics...");
            Car2.MakeEngineNoise(Car2.EngineNoise);
            Car2.MakeHonkNoise(Car2.HonkNoise);
            carLot.ListOfCars.Add(Car2);             // DJ & Amorris suggestion
            Console.WriteLine();

            Car Car3 = new Car();
            Car3.Year = 2022;
            Car3.Make = "Cadillac";
            Car3.Model = "XT4";
            Car3.EngineNoise = "Soft";
            Car3.HonkNoise = "Medium";
            Car3.IsDriveable = "Yes";
            Console.WriteLine($"The {Car3.Model} has the following characteristics...");
            Car3.MakeEngineNoise(Car3.EngineNoise);
            Car3.MakeHonkNoise(Car3.HonkNoise);
            carLot.ListOfCars.Add(Car3);             // DJ & Amorris suggestion      

            Console.WriteLine();
          
            //*************BONUS*************//
            // Set the properties utilizing the 3 different ways we learned about, one way for each car
            // Object  Initializer 
            var Car4 = new Car(2019,"Alfa Romeo","4C","Loud","Medium","Yes");
            Console.WriteLine($"The {Car4.Model} has the following characteristics...");
            Car4.MakeEngineNoise(Car4.EngineNoise);
            Car4.MakeHonkNoise(Car4.HonkNoise);
            carLot.ListOfCars.Add(Car4);             // DJ & Amorris suggestion
            Console.WriteLine();

            //Custom Constructor
            var Car5 = new Car()
            { 
                Year = 2010, 
                Make = "Ford", 
                Model = "Taurus", 
                EngineNoise = "Medium", 
                HonkNoise = "None", 
                IsDriveable = "No" 
            };
            
            Console.WriteLine($"The {Car5.Model} has the following characteristics...");
            Car5.MakeEngineNoise(Car5.EngineNoise);
            Car5.MakeHonkNoise(Car5.HonkNoise);
            carLot.ListOfCars.Add(Car5);             // DJ & Amorris suggestion
            Console.WriteLine();


            Console.WriteLine(" --- ADDED 3 MORE CARS  ---");
            Console.WriteLine();

            Car Car6 = new Car();
            Car6.Year = 2008;
            Car6.Make = "Pontiac";
            Car6.Model = "Solstice";
            Car6.EngineNoise = "Medium";
            Car6.HonkNoise = "Medium";
            Car6.IsDriveable = "Yes";
            Console.WriteLine($"The {Car6.Model} has the following characteristics...");
            Car6.MakeEngineNoise(Car6.EngineNoise);
            Car6.MakeHonkNoise(Car6.HonkNoise);
            carLot.ListOfCars.Add(Car6);             // DJ & Amorris suggestion
            Console.WriteLine();


            var Car7 = new Car(2001, "Dodge", "RAM", "Loud", "Medium", "Yes");
            Console.WriteLine($"The {Car7.Model} has the following characteristics...");
            Car4.MakeEngineNoise(Car7.EngineNoise);
            Car4.MakeHonkNoise(Car7.HonkNoise);
            carLot.ListOfCars.Add(Car7);             // DJ & Amorris suggestion
            Console.WriteLine();

            //Custom Constructor
            var Car8 = new Car()
            {
                Year = 2002,
                Make = "Honda",
                Model = "Civic",
                EngineNoise = "Medium",
                HonkNoise = "None",
                IsDriveable = "No"
            };
            Console.WriteLine($"The {Car8.Model} has the following characteristics...");
            Car5.MakeEngineNoise(Car8.EngineNoise);
            Car5.MakeHonkNoise(Car8.HonkNoise);
            carLot.ListOfCars.Add(Car8);             // DJ & Amorris suggestion
            Console.WriteLine();
            


            Console.WriteLine();                     // DJ & Amorris suggestion
            Console.WriteLine($"Total number of cars on the Car Lot: {carLot.ListOfCars.Count}");
            
            
           
           



            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

           

            


        }




















    }
}
