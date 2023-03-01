using System;

namespace FormulaCuadratica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
            Console.WriteLine("PROGRAMA PARA RESOLVER ECUACIONES DE SEGUNDO GRADO POR MEDIO DE LA FÓRMULA CUADRÁTICA");
            Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");

            double variableA, variableB, variableC, PrimeraSolucionIncompleta, SegundaSolucionIncompleta;
            double PrimeraSolucionCompleta, SegundaSolucionCompleta; //Declaré estas variables porque tuve un problema al ejecutar el programa, lo explico más abajo.

            Console.WriteLine("Introduzca el valor de A");
            variableA= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduzca el valor de B");
            variableB= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduzca el valor de C");
            variableC= Convert.ToDouble(Console.ReadLine());

            PrimeraSolucionIncompleta = (-variableB + Math.Sqrt(Math.Pow(variableB, 2) - 4 * (variableA * variableC)));
            SegundaSolucionIncompleta = (-variableB - Math.Sqrt(Math.Pow(variableB, 2) - 4 * (variableA * variableC)));

            PrimeraSolucionCompleta = (PrimeraSolucionIncompleta/ (2 * variableA)); //Realizo esta operación extra porque por algún motivo la operación "(2 * variableA)" No se estaba realizando.
            SegundaSolucionCompleta = (SegundaSolucionIncompleta/ (2 * variableA)); //Al añadir esta operación el programa funciona bien 

            Console.WriteLine("La primera solución es: " +PrimeraSolucionCompleta);
            Console.WriteLine("La segunda solución es: " +SegundaSolucionCompleta);

            Console.WriteLine("Muchas gracias por usar el programa");
            








        }
    }
}
