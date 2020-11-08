using System;

namespace CarRealisation
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Ford", "Red", 2018, 60, 6);
            car1.Tank(30.7f);
            car1.Drive(354.2f);
            car1.Paint("Yellow");
            //Console.WriteLine(car1.KilometerCounter);
            //Console.WriteLine(car1.TermKilometerCounter);
            //car1.ResetTermKilometerCounter();
            //Console.WriteLine(car1.KilometerCounter);
            //Console.WriteLine(car1.TermKilometerCounter);
            //Console.WriteLine(car1.KilometerCounter);
            //car1.Drive(5.8f);
            //Console.WriteLine(car1.TermKilometerCounter);
            //Console.WriteLine(car1.KilometerCounter);
           
        }

    }
}