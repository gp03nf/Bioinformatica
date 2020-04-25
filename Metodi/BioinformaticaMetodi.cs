using System;
using System.IO;

namespace Metodi
{
    public class BioinformaticaMetodi
    {
        public static string LetturaFile(string nomefile)
        {
            string risposta = "";
            if (File.Exists(nomefile) == true)
                {
                using (StreamReader reader = new StreamReader(nomefile))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        risposta += line;
                    }
                }
            }
            else 
            {
                risposta = "Il file non esiste";
            }
            return risposta;
        }
        public static int Lunghezza(string nomefile)
        {
            string testo = LetturaFile(nomefile);
            int lunghezza = testo.Length;
            return lunghezza;
        }
    }
}
