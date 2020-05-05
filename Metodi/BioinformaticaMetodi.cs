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

        public static int PosizioneErrore (string nomefile1, string nomefile2)
        {
            string resistente = LetturaFile(nomefile1);
            string sensibile = LetturaFile(nomefile2);
            int i = 0;
            while (resistente[i] == sensibile[i])
            {
                i++;
            }
            return i;
        }

        public static string DNAidentico (string nomefile1, string nomefile2)
        {
            string resistente = LetturaFile(nomefile1);
            string sensibile = LetturaFile(nomefile2);
            string porzione = "";
            int k = PosizioneErrore(nomefile1, nomefile2);
            for (int i = 0; i < k; i++)
            {
                porzione += resistente[i];
            }
            return porzione;
        }
    }
}
