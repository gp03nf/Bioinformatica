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
            string risposta1 = BioinformaticaMetodi.DNAidentico(file1, file2);
            int lunghezza = risposta1.Length;
            Console.WriteLine($"{lunghezza} ; {risposta1}");
        }
    }
}