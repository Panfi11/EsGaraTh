using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace EsGaraTh
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.Write("Immetti il numero di partecipanti? ");
            int p = int.Parse(Console.ReadLine());
            List<string> partecipanti = new List<string>();
            for (int i = 1; i <= p; i++)
            {
                Console.WriteLine($"Inserisci il nome del partecipante {i}: ");
                string nome = Console.ReadLine();
                partecipanti.Add(nome);
                Thread t = new Thread(() => Corri(nome));
                t.Start();
            }
            Console.ReadLine();
        }

        private static void Corri(string nome)
        {
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine($"Il partecipante {nome} è al km {i}.");
            }
            Console.WriteLine($"Il partecipante {nome} è arrivato al km 100 e ha terminato la corsa.");
        }
    }

}
