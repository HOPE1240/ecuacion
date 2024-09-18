using System;

namespace EcuacionCuadratica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese dos valores para resolver la ecuación A^2 + B^2 = C^2");
            Console.WriteLine("Ingrese el valor de A o presione Enter para omitir:");
            string inputA = Console.ReadLine();
            double? A = string.IsNullOrEmpty(inputA) ? (double?)null : double.Parse(inputA);

            Console.WriteLine("Ingrese el valor de B o presione Enter para omitir:");
            string inputB = Console.ReadLine();
            double? B = string.IsNullOrEmpty(inputB) ? (double?)null : double.Parse(inputB);

            Console.WriteLine("Ingrese el valor de C o presione Enter para omitir:");
            string inputC = Console.ReadLine();
            double? C = string.IsNullOrEmpty(inputC) ? (double?)null : double.Parse(inputC);

            if (A.HasValue && B.HasValue)
            {
                // Resolver C
                double resultadoC = Math.Sqrt(A.Value * A.Value + B.Value * B.Value);
                Console.WriteLine($"El valor de C es: {resultadoC}");
            }
            else if (A.HasValue && C.HasValue)
            {
                // Resolver B
                double resultadoB = Math.Sqrt(C.Value * C.Value - A.Value * A.Value);
                Console.WriteLine($"El valor de B es: {resultadoB}");
            }
            else if (B.HasValue && C.HasValue)
            {
                // Resolver A
                double resultadoA = Math.Sqrt(C.Value * C.Value - B.Value * B.Value);
                Console.WriteLine($"El valor de A es: {resultadoA}");
            }
            else
            {
                Console.WriteLine("Debe ingresar exactamente dos valores para resolver la ecuación.");
            }

            // Esperar la entrada del usuario para cerrar la aplicación
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}

