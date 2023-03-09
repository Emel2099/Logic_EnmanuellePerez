using System;

namespace Algoritmo_Múltiplos_de_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("##############################################");
            Console.WriteLine("Programa de práctica con múltiplos de 3");
            Console.WriteLine("##############################################");

            int mult3, num1;
            int menu = 1;
            int siesmult3;
            bool multcontador;

            Console.WriteLine("----------------------------------------------");
            

            while (menu == 1)
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Ingrese el número que desee y se le mostrarán los multiplos de 3 hasta ese número");

                num1 = Convert.ToInt32(Console.ReadLine());


                for (mult3 = 1; mult3 <= num1; mult3++)
                {
                    if(mult3%3== 0)
                    {
                        Console.WriteLine("Los números multiplos de 3 son:" + mult3++);
                    }

                }


                Console.WriteLine("Presione 1 para volver al menú o 0 para salir");
                menu= Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                    
            }


        }
    }
}
