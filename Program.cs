using System;

namespace Ejercicio_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#####################################");
            Console.WriteLine("PROGRAMA QUE CALCULA LOS DÍAS, MESES Y AÑOS EN BASE AL NÚMERO INGRESADO");
            Console.WriteLine("#####################################");

            Console.WriteLine("Ingrese el número de días con el cual desea hacer el cálculo");

            double variableamd;
            variableamd = Convert.ToDouble(Console.ReadLine());

            Calcularoperaciones (variableamd, out double opyear, out double opmes, out double opdia);

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("{0:N2} años, {1:N2} meses y {2} días.", opyear, opmes, opdia);
            Console.WriteLine("--------------------------------------------------------");

        }

        static void Calcularoperaciones (double variableamd, out double opyear, out double opmes, out double opdia)
        {
            opdia = variableamd;
            opyear = variableamd / 365;
            opmes = (variableamd / 30) ;
        }
    }
}
