using System;

namespace Salario_de_3_empleados
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("##################################################");
            Console.WriteLine("PROGRAMA PARA DETERMINAR EL SALARIO DE LOS 3 EMPLEADOS");
            Console.WriteLine("##################################################");

            Console.WriteLine("---------------------------------------------------------------");

            string empleado1, empleado2, empleado3;
            int edad1, edad2, edad3;
            double salary1, salary2, salary3;
            double salaryneto1, salaryneto2, salaryneto3;
            double subsidiovejez, impuestojuventud;

            double SalarioTotal;

            Console.WriteLine("Ingrese el nombre, la edad y el salario del primer empleado");
            empleado1 = Console.ReadLine();
            edad1= Convert.ToInt32(Console.ReadLine());
            salary1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre, la edad y el salario del segundo empleado");
            empleado2 = Console.ReadLine();
            edad2= Convert.ToInt32(Console.ReadLine());
            salary2= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre, la edad y el salario del tercer empleado");
            empleado3 = Console.ReadLine();
            edad3= Convert.ToInt32(Console.ReadLine());
            salary3= Convert.ToInt32(Console.ReadLine());

            //EMPLEADO 1
            if (edad1 > 60)
            {
                subsidiovejez = salary1 * 0.25;
                salaryneto1 = salary1 + subsidiovejez;
            }
            else
            {
                if (edad1 < 25)
                {
                    impuestojuventud = salary1 * 0.15;
                    salaryneto1 = salary1 - impuestojuventud;
                }
                else
                {
                    salaryneto1 = salary1;
                }
            }

            Console.Clear();
            Console.WriteLine("Nombre: " + empleado1);
            Console.WriteLine("Edad: " + edad1);
            Console.WriteLine("Salario Neto: " + salaryneto1);

            //EMPLEADO 2
            if (edad2 > 60)
            {
                subsidiovejez = salary2 * 0.25;
                salaryneto2 = salary2 + subsidiovejez;
            }
            else
            {
                if (edad2 < 25)
                {
                    impuestojuventud = salary2 * 0.15;
                    salaryneto2 = salary2 - impuestojuventud;
                }
                else
                {
                    salaryneto2 = salary2;
                }
            }

            Console.WriteLine("Nombre: " + empleado2);
            Console.WriteLine("Edad: " + edad2);
            Console.WriteLine("Salario Neto: " + salaryneto2);

            //EMPLEADO 3
            if (edad3 > 60)
            {
                subsidiovejez = salary3 * 0.25;
                salaryneto3 = salary3 + subsidiovejez;
            }
            else
            {
                if (edad3 < 25)
                {
                    impuestojuventud = salary3 * 0.15;
                    salaryneto3 = salary3 - impuestojuventud;
                }
                else
                {
                    salaryneto3 = salary3;
                }
            }

            Console.WriteLine("Nombre: " + empleado3);
            Console.WriteLine("Edad: " + edad3);
            Console.WriteLine("Salario Neto: " + salaryneto3);

            SalarioTotal = salaryneto1 + salaryneto2 + salaryneto3;

            Console.WriteLine("La suma de los 3 salarios es: "+ SalarioTotal);

        }
    }
}
