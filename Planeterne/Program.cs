using System;
using System.Collections.Generic;
using System.Threading;

namespace Planeterne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //this is a school assignment 
            //makeing a list
            List<Planets> Planet = new List<Planets>();

            //listing til planets
            Planets merkur = new Planets("Markur");
            Planets jorden = new Planets("Jorden");
            Planets mars = new Planets("Mars");
            Planets jupiter = new Planets("Jupiter");
            Planets saturn = new Planets("Saturn");
            Planets uranus = new Planets("Uranus");
            Planets neptun = new Planets("Neptun");
            Planets pluto = new Planets("Pluto");

            //filling the list
            Planet.Add(merkur);
            Planet.Add(jorden);
            Planet.Add(mars);
            Planet.Add(jupiter);
            Planet.Add(saturn);
            Planet.Add(uranus);
            Planet.Add(neptun);
            Planet.Add(pluto);

            //list output
            foreach (Planets p in Planet)
            {
                Console.WriteLine(p);
            }

            //weating 2 sek then
            //clear the console
            Thread.Sleep(2000);
            Console.Clear();

            //making venus and
            //adding venus to the list
            Planets venus = new Planets("Venus");
            Planet.Insert(1, venus);

            Console.WriteLine(Planet);

            //list output
            foreach (Planets pl in Planet)
            {
                Console.WriteLine(pl);
            }

            //weating 2 sek then
            //clear the console
            Thread.Sleep(2000);
            Console.Clear();

            //remove pluto from the list
            Planet.Remove(pluto);

            //list output
            foreach (Planets pla in Planet)
            {
                Console.WriteLine(pla);
            }

            //weating 2 sek then
            //clear the console
            Thread.Sleep(2000);
            Console.Clear();

            //adding pluto back to the list
            Planet.Add(pluto);

            //list output
            for (int i = 0; i < Planet.Count; i++)
            {
                Console.WriteLine(Planet[i]);
            }

            //weating 2 sek then
            //clear the console
            Thread.Sleep(2000);
            Console.Clear();

            //makeing a new list for the mean temperture planets
            List<Planets> meanTemp = new List<Planets>()
            {
                mars, jupiter, saturn, uranus, neptun, pluto
            };

            foreach (Planets plane in meanTemp)
            {
                Console.WriteLine(plane);
            }

            //weating 2 sek then
            //clear the console
            Thread.Sleep(2000);
            Console.Clear();

            //make a list for the planets whit a diameter between 10000 and 50000
            List<Planets> diameter = new List<Planets>()
            {
                jorden, venus, neptun
            };

            //wipe the lists clean
            Planet.Clear();
            meanTemp.Clear();
            diameter.Clear();
        }
    }
}
