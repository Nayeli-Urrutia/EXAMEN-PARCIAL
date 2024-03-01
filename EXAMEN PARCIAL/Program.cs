using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //PROGRAMA #1

            int numero;
            do
            {
                Console.WriteLine("************************************** ");
                Console.WriteLine("Introduzca un número entero positivo: ");
                numero = int.Parse(Console.ReadLine());
            } while (numero <= 0);


            int opcion;
            do
            {
                Console.WriteLine("\nElija una opción:");
                Console.WriteLine("1. Calcular el factorial del número");
                Console.WriteLine("2. Calcular la raíz cuadrada del número");
                Console.WriteLine("3. Salir del programa");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        int factorial = 1;
                        for (int i = 1; i <= numero; i++)
                        {
                            factorial *= i;
                        }
                        Console.WriteLine("El factorial de {0} es {1}", numero, factorial);
                        break;
                    case 2:
                        double raizCuadrada = Math.Sqrt(numero);
                        Console.WriteLine($"La raíz cuadrada de {numero} es {raizCuadrada}");
                        break;
                    case 3:
                        Console.WriteLine("¡Hasta la próxima!");
                        break;


                    default:
                        Console.WriteLine("Opción no válida. Elija una opción del 1 al 3.");
                        break;
                }
                Console.ReadKey();
            } while (opcion != 3);



            // PROGRAMA #2
            int numero1;
            int numero2;
            do
            {
                try
                {
                    Console.WriteLine("Ingrese el Primer Número Entero");
                    string input1 = Console.ReadLine();

                    Console.WriteLine("Ingrese el Segundo Numero Entero ");
                    string input2 = Console.ReadLine();

                    if (int.TryParse(input1, out numero1) && int.TryParse(input2, out numero2))
                    {

                        break;
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Los datos ingresados no son números enteros.");
                }
            } while (true);



            char operador;
            do
            {
                Console.WriteLine("Ingrese el operador matematico (+,-,*,/)");
                operador = Console.ReadKey().KeyChar;
                Console.ReadLine();
                Console.WriteLine("****************************************");
            } while (!ValidarOperador(operador));

            int resultado = 0;
            switch (operador)
            {
                case '+':
                    resultado = numero1 + numero2;
                    break;
                case '-':
                    resultado = numero1 - numero2;
                    break;
                case '*':
                    resultado = numero1 * numero2;
                    break;
                case '/':
                    if (numero2 == 0)
                    {
                        Console.WriteLine("No se puede dividir por 0.");
                        return;
                    }
                    resultado = numero1 / numero2;
                    break;
                default:
                    Console.WriteLine("Operador no válido.");
                    break;
            }

            bool ValidarOperador(char operado)
            {
                return operado == '+' || operado == '-' || operado == '*' || operado == '/';
            }

            Console.WriteLine($"El resultado de {numero1} {operador} {numero2} = {resultado}");
            Console.ReadKey();



            // PROGRAMA #3

            int tabla;

            Console.WriteLine("TABLA DE MULTIPLAR");
            Console.WriteLine(" Ingrese un Número");
            tabla = int.Parse(Console.ReadLine());


            int multiplicar;
            for (int i = 1; i <= 10; i++)
            {
                multiplicar = tabla * i;

                Console.WriteLine($" la tabla de multiplicar de {tabla} * {i} es {multiplicar}");
            }

            Console.ReadKey();


            //Programa #4

            Random random = new Random();
            int numeroAleatorio = random.Next(1, 101);


            int adivinanza;
            bool adivinado = false;
            while (!adivinado)
            {

                Console.WriteLine("Introduce un número entre 1 y 100: ");
                adivinanza = int.Parse(Console.ReadLine());


                if (adivinanza < numeroAleatorio)
                {
                    Console.WriteLine("El número es más grande.");
                }
                else if (adivinanza > numeroAleatorio)
                {
                    Console.WriteLine("El número es más pequeño.");
                }
                else
                {
                    adivinado = true;
                }
            }


            Console.WriteLine("¡Felicidades! Has adivinado el número correctamente.");
            Console.ReadKey();


        }
    }
}


