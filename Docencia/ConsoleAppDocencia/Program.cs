using Docencia;
using System;

namespace ConsoleAppDocencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa de Docencia!");

            Persona p = new Persona("Julio", "Martinez", "García", new DateTime(1969, 5, 3));

            Console.WriteLine(p.DameInfo());

            Console.WriteLine(p.DameInfoEx());

            Console.ReadKey();

        }
    }
}
