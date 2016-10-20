using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();   //zad3
            Car car2 = new Car(2.4, "Audi");    //zad6

            Car car3 = Car.Create();    //zad10




            Console.ReadKey();
        }
    }
}