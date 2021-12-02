using System;

namespace OOPCAR
{
    class Program
    {
        class Car
        {
            string markname;
            string modelname;
            string registration;
            string color;
            int odometer;
            int fueltank;
            public Car(string _markname, string _modelname, string _registration, string _color)
            {
                markname = _markname;
                modelname = _modelname;
                registration = _registration;
                color = _color;
                odometer = 0;
                fueltank = 60;
                Console.WriteLine($"The {markname} {modelname} {registration} of the car has been created");
            }
            public int FuelTank
            {
                get { return fueltank; }
            }
            public void Drive()
            {
                fueltank -= 5;
                odometer += 100;
                Console.WriteLine("vrooom-vroooom");
            }
           public void ShowCarInfo()
           {
                Console.WriteLine($"Mark: {markname}");
                Console.WriteLine($"Model: {modelname}");
                Console.WriteLine($"Registration: {registration}");
                Console.WriteLine($"Color: {color}");
                Console.WriteLine($"Odometer: {odometer}");
                Console.WriteLine($"FuleTank: {fueltank}");
           }
        }
        static void Main(string[] args)
        {
           Car myCar = new Car("Mustang", "GT", "BTS007", "blue-white");
            while (myCar.FuelTank >0)
            {
                myCar.Drive();
            }
            myCar.ShowCarInfo();
        }
        
    }
}
