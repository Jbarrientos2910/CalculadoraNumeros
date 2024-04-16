using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CalculadoraNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            int operacion;
            string opcion;
            Suma s1;
            Resta r1;
            Producto p1;
            Division d1;

            do
            {
                Console.Clear();
                Console.WriteLine(" ----------------- 0 -----------------");
                Console.WriteLine("Ingrese la operación que desea realizar");
                Console.WriteLine("1 = Suma / 2 = Resta / 3 = Producto / 4 = Division");
                operacion = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                Console.WriteLine(" ----------------- 0 -----------------");
                Console.WriteLine("Ingrese el primer número: ");
                numero1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número: ");
                numero2 = Convert.ToInt32(Console.ReadLine());

                s1 = new Suma( numero1 , numero2 );
                r1 = new Resta( numero1, numero2 );
                p1 = new Producto( numero1 , numero2 );
                d1 = new Division( numero1 , numero2 );

                if ( operacion == 1 )
                    {
                        Console.Clear();
                        s1.CalcularSuma( numero1 , numero2 );
                        Console.WriteLine(" ----------------- 0 -----------------");
                        Console.WriteLine("Los números ingresados fueron: ");
                        Console.WriteLine("1° Número: " + s1.Numero1);
                        Console.WriteLine("2° Número: " + s1.Numero2);
                        Console.WriteLine("La suma de ambos números es: " + s1.Resultado);
                        Console.WriteLine(" ----------------- 0 -----------------");
                        Console.WriteLine("Presione ENTER para continuar");
                        Console.ReadLine();

                }

                if ( operacion == 2)
                    {
                        Console.Clear();
                        r1.CalcularResta( numero1 , numero2 );
                        Console.WriteLine(" ----------------- 0 -----------------");
                        Console.WriteLine("Los números ingresados fueron: ");
                        Console.WriteLine("1° Número: " + r1.Numero1);
                        Console.WriteLine("2° Número: " + r1.Numero2);
                        Console.WriteLine("La resta de ambos números es: " + r1.Resultado);
                        Console.WriteLine(" ----------------- 0 -----------------");
                        Console.WriteLine("Presione ENTER para continuar");
                        Console.ReadLine();

                }

                if ( operacion == 3)
                    {
                        Console.Clear();
                        p1.CalcularProducto( numero1 , numero2 );
                        Console.WriteLine(" ----------------- 0 -----------------");
                        Console.WriteLine("Los números ingresados fueron: ");
                        Console.WriteLine("1° Número: " + p1.Numero1);
                        Console.WriteLine("2° Número: " + p1.Numero2);
                        Console.WriteLine("El producto de ambos números es: " + p1.Resultado);
                        Console.WriteLine(" ----------------- 0 -----------------");
                        Console.WriteLine("Presione ENTER para continuar");
                        Console.ReadLine();

                }
                if ( operacion == 4)
                    {
                        if (d1.Numero2 != 0) { 
                            Console.Clear();
                            d1.CalcularDivision( numero1 , numero2 );
                            Console.WriteLine(" ----------------- 0 -----------------");
                            Console.WriteLine("Los números ingresados fueron: ");
                            Console.WriteLine("1° Número: " + d1.Numero1);
                            Console.WriteLine("2° Número: " + d1.Numero2);
                            Console.WriteLine("El producto de ambos números es: " + d1.Resultado);
                            Console.WriteLine(" ----------------- 0 -----------------");
                            Console.WriteLine("Presione ENTER para continuar");
                            Console.ReadLine();
                        } 
                        else
                        {
                            Console.Clear();
                            Console.WriteLine(" ----------------- 0 -----------------");
                            Console.WriteLine("No se puede dividir por 0");
                            Console.WriteLine(" ----------------- 0 -----------------");
                            Console.WriteLine("Presione ENTER para continuar");
                            Console.ReadLine();
                        }

                }
                if ( operacion > 4 || operacion < 1)
                    {
                        Console.Clear();
                        Console.WriteLine(" ----------------- 0 -----------------");
                        Console.WriteLine("La opción ingresada no es válida.");
                        Console.WriteLine(" ----------------- 0 -----------------");
                        Console.WriteLine("Presione ENTER para continuar");
                        Console.ReadLine();
                    }

                Console.Clear();
                Console.WriteLine(" ----------------- 0 -----------------");
                Console.WriteLine("¿Desea realizar otra operación? [s/n]");
                opcion = Console.ReadLine();
                if (opcion == "N" || opcion == "n")
                {
                    break;
                }

            } while (true);

        }
    }
}
