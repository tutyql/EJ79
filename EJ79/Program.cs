using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ79
{
    class Program
    {
        static void Main(string[] args)
        {
            string Frase;

            SortedSet<string> datos = new SortedSet<string>();

            Console.WriteLine("Ingrese una frase");
            Frase = Console.ReadLine();

            while (Frase != " ")
            {
                if (datos.Contains(Frase))
                {
                    Console.WriteLine("\nESTA FRASE YA EXISTE\n---------------\n");
                }
                datos.Add(Frase);
                Console.WriteLine("\nIngrese siguente frase\n");
                Frase = Console.ReadLine();
            }

            

        }
    }
}
