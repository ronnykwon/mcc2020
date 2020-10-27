using System;
using System.Linq;

namespace ExerciceTableau
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] nombres = new int[] { 5, 48, 69, 33, 2, 77, 10, 23, 6, 89 };
            int somme = 0;
            int moyenne = 0;
            int minimum = nombres[0];
            int maximum = nombres[0];
            for(int i = 0; i< nombres.Length; i++)
            {
                somme += nombres[i];
                if(nombres[i] < minimum)
                {
                    minimum = nombres[i];
                }

                if(nombres[i] > maximum)
                {
                    maximum = nombres[i];
                }
            }

            nombres.Sum();
            nombres.Average();
            nombres.Max();
            nombres.Min();

            moyenne = somme / nombres.Length;
            Console.WriteLine("Somme : {0}", somme);
            Console.WriteLine("Moyenne : {0}", moyenne);
            Console.WriteLine("Minimum : {0}", minimum);
            Console.WriteLine("Maximum : {0}", maximum);
        }

        public static void BoucleFor()
        {
            int[] nombres = new int[] { 5, 48, 69, 33, 2, 77, 10, 23, 6, 89 };
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i]);
            }
        }










        public static void Somme()
        {
            int somme = 0;


            somme = somme + 10;


            somme = somme + 20;
            
            somme = somme + 5;

            somme++;

            somme = somme + 1;
        }
    }
}
