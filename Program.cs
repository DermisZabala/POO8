using System;

namespace POO8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creación de una clase anónima
            var persona = new {nombre = "Juan", edad = 20};
            Console.WriteLine($"{persona.nombre} {persona.edad}");

            var otraPersona = new {nombre = "Hamel", edad = 19};
            Console.WriteLine($"{otraPersona.nombre} {otraPersona.edad}");

            Console.ReadKey();
        }
    }
}
