using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamenLuisGalvez1905
{
    class Program
    {
        //Contar cuantos números tienen 3ra y cuales son en la serie del 1 al 9000
        class Numeros
        {

            public void ContarNumeros()
            {
                Console.WriteLine("Sacar 3ra de números 1 - 9000.");
                for (int i = 1; i <= 9000; i++)
                {
                    if (i % 3 == 0)
                    {
                        //contador = contador + i;
                        Console.Write(i + " - ");
                    }
                }
                Console.ReadKey();
            }
        }

        static void Main(string[] args)
        {
            Numeros n = new Numeros();
            n.ContarNumeros();
        }
    }
}
