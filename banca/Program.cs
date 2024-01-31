using System;

namespace banca
{
    internal class Program
    {
        static void Main(string[] args)
        {   // Esercizio 1

            ContoCorrente Conto1 = new ContoCorrente();
            Console.WriteLine("Importo iniziale: ");
            decimal importoIniziale = decimal.Parse(Console.ReadLine());
            Conto1.ApriConto(importoIniziale);

            Console.WriteLine("Versamento: ");
            decimal importoVersamento = decimal.Parse(Console.ReadLine());
            Conto1.Versamento(importoVersamento);

            Console.WriteLine("Prelievo: ");
            decimal importoPrelievo = decimal.Parse(Console.ReadLine());
            Conto1.Preleva(importoPrelievo);

            // Esercizio 2

            Console.WriteLine("Quanti nomi vuoi inserire (numero):");
            int numeroNomi = int.Parse(Console.ReadLine());

            string[] nomi = new string[numeroNomi];

            Console.WriteLine("Inserisci i nomi:");

            for (int i = 0; i < nomi.Length; i++)
            {
                nomi[i] = Console.ReadLine();
            }

            Console.WriteLine("Nome da verificare:");
            string nome = Console.ReadLine();

            bool presente = false;

            for (int i = 0; i < nomi.Length; i++)
            {
                if (nome == nomi[i])
                {
                    presente = true;
                    break;
                }
            }

            if (presente)
            {
                Console.WriteLine($"Il nome {nome} è presente nella lista");
            }
            else
            {
                Console.WriteLine("Il nome non è presente in lista");
            }

            // Esercizio 3

            Console.WriteLine("Dimensione dell'array:");
            int dimensioneArray = int.Parse(Console.ReadLine());

            int[] numeri = new int[dimensioneArray];

            Console.WriteLine("Inserisci i numeri:");

            for (int i = 0; i < numeri.Length; i++)
            {
                numeri[i] = int.Parse(Console.ReadLine());
            }
            int somma = 0;
            for (int i = 0; i < numeri.Length; i++)
            {
                somma += numeri[i];
            }
            Console.WriteLine($"La somma di tutti i numeri nell'array è: {somma}");

            double media = (double)somma / numeri.Length;
            Console.WriteLine($"La media di tutti i numeri inseriti nell'array è: {media}");
        }



        public class ContoCorrente
        {
            private bool contoAperto = false;
            private decimal saldo = 0;


            public void ApriConto(decimal importoIniziale)
            {
                if (!contoAperto && importoIniziale >= 1000)
                {
                    contoAperto = true;
                    saldo = importoIniziale;
                    Console.WriteLine($"Il conto è stato aperto , saldo attuale : {saldo} euro.");
                }
                else
                {
                    Console.WriteLine($"Impossibile aprire il conto con {importoIniziale} euro . Devi avere almeno 1000 euro.");
                }
            }

            public void Versamento(decimal importo)
            {
                if (contoAperto == true && importo > 1000)
                {
                    saldo += importo;
                    Console.WriteLine($"Versamento di {importo} euro effettuato. Nuovo saldo: {saldo}");
                }
                else
                {
                    Console.WriteLine("Impossibile effettuare versamento, minimo 1000 euro");
                }  
            }

            public void Preleva(decimal importo) 
            {
                if(contoAperto == true && importo >= 0 && saldo >= importo)
                {
                    saldo -= importo;
                    Console.WriteLine($"Prelievo di {importo} euro, effettuato. Nuovo saldo: {saldo}");
                }
                else
                {
                    Console.WriteLine($"Impossibile effettuare il prelievo");
                }
            }
        }
    }
}
