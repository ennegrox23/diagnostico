using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("Seleccione un numero del 1 al 9");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    for (int i = 0; i <= 50; i++)
                    {
                        while (i < 50)
                        {
                            i = i + 1;
                            Console.WriteLine(i);
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i <= 50; i++)
                    {
                        while (i < 50)
                        {
                            i = i + 2;
                            Console.WriteLine(i);
                        }
                    }
                    break;
                case 3:
                    int N;
                    int N2;
                    Console.WriteLine("Solicite El 1er Numero");
                    N = int.Parse(Console.ReadLine());
                    Console.WriteLine("Solicite El 2do Numero");
                    N2 = int.Parse(Console.ReadLine());
                    for (int i = N - 1; i <= N; i++)
                    {
                        while (i < N2)
                        {
                            i = i + 1;

                            Console.WriteLine(i);
                        }
                    }
                    break;
                case 4:
                    for (int i = 1; i <= 50; i++)
                    {
                        Console.WriteLine(i);
                    }
                    break;
                case 5:
                    for (int i = 1; i <= 50; i++)
                    {
                        i = i + 1;
                        Console.WriteLine(i);
                    }
                    break;
                case 6:
                    Console.WriteLine("Solicite El 1er Numero");
                    N = int.Parse(Console.ReadLine());
                    Console.WriteLine("Solicite El 2do Numero");
                    N2 = int.Parse(Console.ReadLine());
                    for (int i = N; i <= N2; i++)
                    {
                        Console.WriteLine(i);
                    }
                    break;
                case 7:
                    do
                    {
                        Console.WriteLine("Ingrese Un Numero Del 1 Al 7");
                        N = int.Parse(Console.ReadLine());
                        if (N == 1)
                        {
                            Console.WriteLine("Lunes");
                        }
                        else if (N == 2)
                        {
                            Console.WriteLine("Martes");
                        }
                        else if (N == 3)
                        {
                            Console.WriteLine("Miercoles");
                        }
                        else if (N == 4)
                        {
                            Console.WriteLine("Jueves");
                        }
                        else if (N == 5)
                        {
                            Console.WriteLine("Viernes");
                        }
                        else if (N == 6)
                        {
                            Console.WriteLine("Sabado");
                        }
                        else if (N == 7)
                        {
                            Console.WriteLine("Domingo");
                        }
                        else
                        {
                            Console.WriteLine("Error: Seleccione un numero valido");
                        }
                    } while (true);
                    break;
                case 8:
                    break;
                case 9:
                    break;
            }
            Console.ReadKey();
        }
    }
}