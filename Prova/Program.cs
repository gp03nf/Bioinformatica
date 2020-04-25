using System;
using Metodi;

namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserisci il nome del file 1: ");
            string file1 = Console.ReadLine();
            Console.Write("Inserisci il nome del file 2: ");
            string file2 = Console.ReadLine();
            int risposta1 = BioinformaticaMetodi.Lunghezza(file1);
            int risposta2 = BioinformaticaMetodi.Lunghezza(file2);
            Console.WriteLine($"La lunghezza è {risposta1}");
            Console.WriteLine($"La lunghezza è {risposta2}");
        }
    }
}
