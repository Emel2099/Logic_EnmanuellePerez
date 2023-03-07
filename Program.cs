using System;

namespace Ejercicio_de_práctica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("Calculadora aritmética");
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");

            double primernumero;
            double segundonumero;

            double suma, resta, mult, division;

            double resultado;

            int encendido = 1;



            while (encendido==1)
            {
                Console.WriteLine("Ingrese el primer número");
                primernumero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número");
                segundonumero = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Que desea hacer con estos números?");
                Console.WriteLine("Presione 1 para sumarlos");
                Console.WriteLine("Presione 2 para restarlos");
                Console.WriteLine("Presione 3 para multiplicarlos");
                Console.WriteLine("Presione 4 para dividirlos");

                resultado = Convert.ToInt32(Console.ReadLine());

                switch (resultado)
                {
                    case 1:
                        suma = primernumero + segundonumero;
                        Console.WriteLine("El resultado de la suma es:" + suma);
                        break;

                    case 2:
                        resta = primernumero - segundonumero;
                        Console.WriteLine("El resultado de la resta es:" + resta);
                        break;

                    case 3:
                        mult = primernumero * segundonumero;
                        Console.WriteLine("El resultado de la multiplicación es:" + mult);
                        break;

                    case 4:
                        if (segundonumero == 0)
                        {
                            Console.WriteLine("La división es indeterminada");

                        }
                        else
                        {
                            division = primernumero / segundonumero;
                            Console.WriteLine("El resultado de la división es:" + division);
                        }

                        break;

                    default:
                        Console.WriteLine("Presione una opción válida");
                        break;







                }
              
                Console.WriteLine("Presiona 1 para volver al menú o 0 para salir de la calculadora");
                encendido = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

            }
            
            
               

          




        }
    }
}
