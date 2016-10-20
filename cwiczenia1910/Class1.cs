using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Car   //zad1
    {
        private double pojemnoscSilnika; //zad2
        private string marka;
        static int iloscKol;

        public Car()    //zad4
        {
            pojemnoscSilnika = 2.3;
            marka = "blabla";
        }
        public Car(double pojemnoscSilnika, string marka)   //zad5
        {
            this.pojemnoscSilnika = pojemnoscSilnika;
            this.marka = marka;

        }
        static public Car Create()  //zad9
        {
            return new Car();
        }

        static Car()
        {
            iloscKol = 4;
        }

        ~Car()
        {
            Console.WriteLine("Zwalniam pamiec");
            Console.ReadKey();
        }
    }
}