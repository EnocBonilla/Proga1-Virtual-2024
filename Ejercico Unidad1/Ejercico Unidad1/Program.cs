using System;

namespace GuiadeEjercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine(" MENU ");
                Console.WriteLine("1. Número es positivo o negativo");
                Console.WriteLine("2. Tabla de multiplicar");
                Console.WriteLine("3. Suma de números positivos");
                Console.WriteLine("4. Número es primo");
                Console.WriteLine("5. Promedio de una serie de números");
                Console.WriteLine("6. Salir");
                Console.Write("Opción: ");

                string opcion = Console.ReadLine();
                //Ejercicios segun Guia Bloque 1
                switch (opcion)
                {
                    case "1":
                        PositivoNegativo();
                        break;
                    case "2":
                        TablaMultiplicar();
                        break;
                    case "3":
                        SumaNumPositivos();
                        break;
                    case "4":
                        NumPirmo();
                        break;
                    case "5":
                        PromedioNum();
                        break;
                    case "6":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida, intente de nuevo.");
                        break;
                }
                if (!salir)
                {
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }

        static void PositivoNegativo()
        {
            Console.Clear();
            int numero;
            do
            {
                Console.Write("Ingrese un número (0 para salir): ");
                numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    Console.WriteLine("El número es positivo.");
                }
                else if (numero < 0)
                {
                    Console.WriteLine("El número es negativo.");
                }

            } while (numero != 0);
        }

        static void TablaMultiplicar()
        {
            Console.Clear();
            int numero;
            do
            {
                Console.Write("Ingrese un número entre 1 y 10 (0 para salir): ");
                numero = int.Parse(Console.ReadLine());

                if (numero >= 1 && numero <= 10)
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine($"{numero} x {i} = {numero * i}");
                    }
                }
                else if (numero != 0)
                {
                    Console.WriteLine("Número fuera del rango válido.");
                }

            } while (numero != 0);
        }

        static void SumaNumPositivos()
        {
            Console.Clear();
            int suma = 0;
            int numero;
            do
            {
                Console.Write("Ingrese un número positivo (0 o negativo para salir): ");
                numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    suma += numero;
                    Console.WriteLine($"Suma actual: {suma}");
                }

            } while (numero > 0);
            Console.WriteLine($"Suma final: {suma}");
        }

        static void NumPirmo()
        {
            Console.Clear();
            Console.Write("Ingrese un número: ");
            int numero = int.Parse(Console.ReadLine());

            if (EsPrimo(numero))
            {
                Console.WriteLine("El número es primo.");
            }
            else
            {
                Console.WriteLine("El número no es primo.");
            }
        }

        static bool EsPrimo(int numero)
        {
            if (numero <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0) return false;
            }
            return true;
        }

        static void PromedioNum()
        {
            Console.Clear();
            int suma = 0;
            int contador = 0;
            int numero;
            do
            {
                Console.Write("Ingrese un número (0 para finalizar): ");
                numero = int.Parse(Console.ReadLine());

                if (numero != 0)
                {
                    suma += numero;
                    contador++;
                }

            } while (numero != 0);

            if (contador > 0)
            {
                double promedio = (double)suma / contador;
                Console.WriteLine($"El promedio es: {promedio}");
            }
            else
            {
                Console.WriteLine("No se ingresaron números.");
            }
        }
    }
}
