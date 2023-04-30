using System;
using System.Runtime.CompilerServices;

namespace Corso
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 2;
            string risultato;
            //CICLO IF
            if (numero == 3)
            {
                Console.WriteLine("numero e' 2");
            } else if(numero == 4)
            {
                Console.WriteLine("numero e' 4");
            } else {  
                Console.WriteLine("numero non e' ne' 2 ne' 4");    
            }

            //OPERATORE TERNARIO
            numero = numero==2 ? 2 : 3;
            risultato = numero == 2 ? "2" : "non e' 2";
            //ANCROA UN'ALTRA CONDIZIONE
            risultato = numero % 2 != 0 ? "dispari" : (numero < 10 ? "pari e minori di 10" : "pari e maggiore di 10");

            //SWITCH
            int numero2 = 35;
            switch(numero2)
            {
                case 35:
                    Console.WriteLine("E' 35");
                    if (risultato == "io")
                    {
                        Console.WriteLine("sono io");
                    }
                    break;
                case 30:
                    Console.WriteLine("E' 30");
                    break;
                default:
                    Console.WriteLine("non ho indovinato");
                    break;
            }

            //CICLI WHILE E DO WHILE
            int persone = 10;
            int i = 0;
            while(i <= persone)
            {
                Console.WriteLine(i);
                i++;
            }
            int persone2 = 10;
            int ii = 0;
            do
            {
                Console.WriteLine(ii);
                ii++;
            } while(ii <= persone2);

            //CICLO FOR
            for(int y = 0; y<=10; y++)
            {
                Console.WriteLine(y);
            }
            //CICLO FOREACH
            string[] nomi = { "ang", "luc", "io" };
            foreach (string nome in nomi)
            {
                if (nome == "io") break; //esce dal ciclo
                if (nome == "ang") continue; //va al prossimo item dell'array
                Console.WriteLine(nome);
            }
        }
    }
}
