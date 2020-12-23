using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace ProyectoCine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cinemark  -  EL SALVADOR";
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            int op;
            int sums1 = 0, sums2 = 0, sums3 = 0, sums4 = 0;
            int s;
            int unafuncion, unafuncion2, unafuncion3, unafuncion4;
            DateTime diaHoy = DateTime.Now;
            string dms = diaHoy.ToString("d");

            int[] fcsl1 = new int[20];

            for (int i = 0; i < 20; i++)
            {
                fcsl1[i] = i + 1;
            }

            int[] fcsl2 = new int[20];
            for (int i = 0; i < 20; i++)
            {
                fcsl2[i] = i + 1;
            }

            int[] fcsl3 = new int[20];
            for (int i = 0; i < 20; i++)
            {
                fcsl3[i] = i + 1;
            }

            int[] fcsl4 = new int[20];
            for (int i = 0; i < 20; i++)
            {
                fcsl4[i] = i + 1;
            }

            do
            {
                Console.WriteLine("\n\t\t*****************************************************");
                Console.WriteLine("\t\t*                                                   *");
                Console.WriteLine("\t\t*                                                   *");
                Console.WriteLine("\t\t*                                                   *");
                Console.WriteLine("\t\t*               BIENVENIDO A CINEMARK               *");
                Console.WriteLine("\t\t*                     SOYAPANGO                     *");
                Console.WriteLine("\t\t*                                                   *");
                Console.WriteLine("\t\t*                     {0}                    *", dms);
                Console.WriteLine("\t\t*                                                   *");
                Console.WriteLine("\t\t*     Precione cualquier tecla para continuar...    *");
                Console.WriteLine("\t\t*                                                   *");
                Console.WriteLine("\t\t*                                                   *");
                Console.WriteLine("\t\t*                                                   *");
                Console.WriteLine("\t\t*****************************************************");
                Console.ReadKey();
                Console.Clear();
                op = Salas();
                Console.WriteLine("La opción seleccionada es: " + op);
                Console.WriteLine("\n");

                switch (op)
                {
                    case 1:
                        if (sums1 < 16)
                        {
                            unafuncion = Sala1(fcsl1, sums1);
                            Console.WriteLine("Asientos ocupados: " + unafuncion);
                            sums1 = unafuncion;
                        }
                        else if (sums1 == 16)
                        {
                            Console.WriteLine("Sala llena");
                            Console.WriteLine("Presione cualquier tecla para continuar");
                        }

                        break;
                    case 2:
                        if (sums2 < 16)
                        {
                            unafuncion2 = Sala2(fcsl2, sums2);
                            Console.WriteLine("Asientos ocupados: " + unafuncion2);
                            sums2 = unafuncion2;
                        }
                        else if (sums2 == 16)
                        {
                            Console.WriteLine("Sala llena");
                            Console.WriteLine("Presione cualquier tecla para continuar");
                        }

                        break;
                    case 3:
                        if (sums3 < 16)
                        {
                            unafuncion3 = Sala3(fcsl3, sums3);
                            Console.WriteLine("Asientos ocupados: " + unafuncion3);
                            sums3 = unafuncion3;
                        }
                        else if (sums3 == 16)
                        {
                            Console.WriteLine("Sala llena");
                            Console.WriteLine("Presione cualquier tecla para continuar");
                        }

                        break;
                    case 4:
                        if (sums4 < 16)
                        {
                            unafuncion4 = Sala4(fcsl4, sums4);
                            Console.WriteLine("Asientos ocupados: " + unafuncion4);
                            sums4 = unafuncion4;
                        }
                        else if (sums4 == 16)
                        {
                            Console.WriteLine("Sala llena");
                            Console.WriteLine("Presione cualquier tecla para continuar");
                        }

                        break;
                    case 5:
                        Informacion();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\n\tSe ha producido un error, intente nuevamente...");
                        Console.ReadKey();
                        break;
                }
                Console.Write("Si desea continuar presione [1], sino [0]: ");
                s = int.Parse(Console.ReadLine());
                Console.Clear();
            } while (s == 1);
            Console.WriteLine("Gracias por Preferirnos");
            Console.ReadKey();
        }
        //Area de Elección de salas
        static int Salas()
        {
            int p = 1;

            do
            {
                if (p < 0 || p > 5)
                {
                    Console.WriteLine("\n\tRango de valores no válido, intente de nuevo...");
                    Console.Write("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
                
                Console.WriteLine("\n\t\t      <<CARTELERA>>");
                Console.WriteLine("\n\t\t     1.Sala  1 : Avengers 4 [$3.50]");
                Console.WriteLine("\t\t     2.Sala 2 : Asedio [$3.50]");
                Console.WriteLine("\t\t     3.Sala 3: Star Wars : La Amenaza Fantasma [$5.59]");
                Console.WriteLine("\t\t     4.Sala 4: Toy Story 4 [$5.59]");
                Console.WriteLine("\t\t     5.Información sobre cada sala");
                Console.Write("\n\t\t      Elija una opción: ");
                p = int.Parse(Console.ReadLine());
                Console.Clear();

            } while (p < 0 || p > 5);
            return p;
        }

        static void Informacion()
        {
            Console.Clear();
            string[,] info = new string[5, 3]
                {
                {"Sala", "\tinformación", "\tExibiendose"},
                {"Sala 1","\tDigital 2D", "\tAvengers: End Game"},
                {"Sala 2","\tDigital 2D", "\tAsedio"},
                {"Sala 3","\tReal 3D","\t\tStar wars Episodio IX"},
                {"Sala 4","\tReal 3D","\t\tToy Story 4"}
                };

            Pantalla(info);
        }

        public static void Pantalla<T>(T[,] matriz)
        {
            var filas = matriz.GetLength(0);
            var columnas = matriz.GetLength(1);
            var sb = new StringBuilder();
            var tmpfila = new T[matriz.GetLength(0)];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    tmpfila[j] = matriz[i, j];
                }
                sb.AppendLine(string.Join("\t", tmpfila));
                sb.AppendLine("");
            }
            Console.WriteLine(sb.ToString());
        }
        // Fin de Área de selección de salas
        //Inicio de la Área de la sal 1
        static int Sala1(int[] fcs1, int sum1)
        {
            Console.Clear();
            int tic1;
            int dis = 16 - sum1;
            int[] asientos1 = new int[20];
            Console.WriteLine("Usted a seleccinado la Sala 1 - Avengers: End Game");
            Console.WriteLine("¿Cuántas entradas desea comprar?");
            tic1 = int.Parse(Console.ReadLine());

            while (tic1 > dis || tic1 < 1)
            {
                Console.WriteLine("La cantidad ingresada supera los asientos disponibles o el valor no es valido");
                Console.WriteLine("Asientos disponibles {0}", dis);
                Console.WriteLine("Vuelva a hacer su pedido en ese rango");
                Console.WriteLine("¿Cuántas entradas desea comprar?");
                tic1 = int.Parse(Console.ReadLine());
            }

            sum1 = sum1 + tic1;
            Console.WriteLine("Asientos ocupados son: " + sum1);
            Console.WriteLine("Asientos disponibles son: " + (dis - tic1));
            Console.WriteLine("Usted a seleccionado {0} asientos", tic1);
            Console.WriteLine("\n");

            for (int i = 0; i <= tic1; i++)
            {
                int[,] sal1 = new int[4, 4]
                {
                     {fcs1[0],fcs1[1],fcs1[2],fcs1[3]},{fcs1[4],fcs1[5],fcs1[6],fcs1[7]},
                     {fcs1[8],fcs1[9],fcs1[10],fcs1[11]},{fcs1[12],fcs1[13],fcs1[14],fcs1[15]}
                };
                PantallaSala1(sal1);
                Console.WriteLine("\n");
                if (i < tic1)
                {
                    Console.Write("Elija el asiento que desea: ");
                    asientos1[i] = int.Parse(Console.ReadLine());
                    while (asientos1[i] <= 0 || asientos1[i] > 16)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Esta fuera del rango o esta agotado vuelva a intentarlo");
                        Console.Write("Elija el asiento que desea: ");
                        asientos1[i] = int.Parse(Console.ReadLine());
                    }
                    while ((asientos1[i] == 1 && fcs1[0] == 0) || (asientos1[i] == 2 && fcs1[1] == 0) || (asientos1[i] == 3 && fcs1[2] == 0) || (asientos1[i] == 4 && fcs1[3] == 0) || (asientos1[i] == 5 && fcs1[4] == 0) || (asientos1[i] == 6 && fcs1[5] == 0) || (asientos1[i] == 7 && fcs1[6] == 0) || (asientos1[i] == 8 && fcs1[7] == 0))
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Esta fuera del rango o esta agotado vuelva a intentarlo");
                        Console.Write("Elija el asiento que desea: ");
                        asientos1[i] = int.Parse(Console.ReadLine());
                    }
                    while ((asientos1[i] == 9 && fcs1[8] == 0) || (asientos1[i] == 10 && fcs1[9] == 0) || (asientos1[i] == 11 && fcs1[10] == 0) || (asientos1[i] == 12 && fcs1[11] == 0) || (asientos1[i] == 13 && fcs1[12] == 0) || (asientos1[i] == 14 && fcs1[13] == 0) || (asientos1[i] == 15 && fcs1[14] == 0) || (asientos1[i] == 16 && fcs1[15] == 0))
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Esta fuera del rango o esta agotado vuelva a intentarlo");
                        Console.Write("Elija el asiento que desea: ");
                        asientos1[i] = int.Parse(Console.ReadLine());
                    }
                    Console.Clear();

                    if (asientos1[i] == 1 && fcs1[0] == 1)
                    {
                        fcs1[0] = 0;

                    }

                    else if (asientos1[i] == 2 && fcs1[1] == 2)
                    {
                        fcs1[1] = 0;
                    }
                    else if (asientos1[i] == 3 && fcs1[2] == 3)
                    {
                        fcs1[2] = 0;

                    }
                    else if (asientos1[i] == 4 && fcs1[3] == 4)
                    {
                        fcs1[3] = 0;

                    }
                    else if (asientos1[i] == 5 && fcs1[4] == 5)
                    {
                        fcs1[4] = 0;

                    }
                    else if (asientos1[i] == 6 && fcs1[5] == 6)
                    {

                        fcs1[5] = 0;
                    }
                    else if (asientos1[i] == 7 && fcs1[6] == 7)
                    {
                        fcs1[6] = 0;

                    }
                    else if (asientos1[i] == 8 && fcs1[7] == 8)
                    {
                        fcs1[7] = 0;

                    }
                    else if (asientos1[i] == 9 && fcs1[8] == 9)
                    {
                        fcs1[8] = 0;

                    }
                    else if (asientos1[i] == 10 && fcs1[9] == 10)
                    {
                        fcs1[9] = 0;

                    }
                    else if (asientos1[i] == 11 && fcs1[10] == 11)
                    {
                        fcs1[10] = 0;

                    }
                    else if (asientos1[i] == 12 && fcs1[11] == 12)
                    {
                        fcs1[11] = 0;

                    }
                    else if (asientos1[i] == 13 && fcs1[12] == 13)
                    {
                        fcs1[12] = 0;

                    }
                    else if (asientos1[i] == 14 && fcs1[13] == 14)
                    {
                        fcs1[13] = 0;

                    }
                    else if (asientos1[i] == 15 && fcs1[14] == 15)
                    {
                        fcs1[14] = 0;

                    }
                    else if (asientos1[i] == 16 && fcs1[15] == 16)
                    {
                        fcs1[15] = 0;

                    }
                }
                else
                {
                    Console.ReadKey();
                }
            }
            Console.WriteLine("\n");

            for (int i = 0; i < tic1; i++)
            {
                Console.Write("\t" + asientos1[i]);
            }
            Console.WriteLine("\n");
            Console.ReadKey();
            return sum1;
        }
        public static void PantallaSala1(int[,] matriz)
        {
            var filas = matriz.GetLength(0);
            var columnas = matriz.GetLength(1);
            var sb = new StringBuilder();
            var tmpfila = new int[matriz.GetLength(0)];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    tmpfila[j] = matriz[i, j];
                }
                sb.AppendLine(string.Join("\t", tmpfila));
                sb.AppendLine("");
            }
            Console.WriteLine(sb.ToString());

        }
        //Fin de la Área de la sala 1
        //Inicio del Área de la sala 2
        static int Sala2(int[] fcs2, int sum2)
        {
            Console.Clear();
            int tic2;
            int dis = 16 - sum2;
            int[] asientos2 = new int[20];
            Console.WriteLine("Usted a seleccinado la Sala 2 - Asedio");
            Console.WriteLine("¿Cuántas entradas desea comprar?");
            tic2 = int.Parse(Console.ReadLine());

            while (tic2 > dis || tic2 < 1)
            {
                Console.WriteLine("La cantidad ingresada supera los asientos disponibles o el valor no es valido");
                Console.WriteLine("Asientos disponibles {0}", dis);
                Console.WriteLine("Vuelva a hacer su pedido en ese rango");
                Console.WriteLine("¿Cuántas entradas desea comprar?");
                tic2 = int.Parse(Console.ReadLine());
            }

            sum2 = sum2 + tic2;
            Console.WriteLine("Asientos ocupados son: " + sum2);
            Console.WriteLine("Asientos disponibles son: " + (dis - tic2));
            Console.WriteLine("Usted a seleccionado {0} asientos", tic2);
            Console.WriteLine("\n");

            for (int i = 0; i <= tic2; i++)
            {
                int[,] sal2 = new int[4, 4]
                 {
                     {fcs2[0],fcs2[1],fcs2[2],fcs2[3]},{fcs2[4],fcs2[5],fcs2[6],fcs2[7]},
                     {fcs2[8],fcs2[9],fcs2[10],fcs2[11]},{fcs2[12],fcs2[13],fcs2[14],fcs2[15]}
                 };
                PantallaSala2(sal2);
                Console.WriteLine("\n");
                if (i < tic2)
                {
                    Console.Write("Elija el asiento que desea: ");
                    asientos2[i] = int.Parse(Console.ReadLine());
                    while (asientos2[i] <= 0 || asientos2[i] > 16)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Esta fuera del rango o esta agotado vuelva a intentarlo");
                        Console.Write("Elija el asiento que desea: ");
                        asientos2[i] = int.Parse(Console.ReadLine());
                    }
                    while ((asientos2[i] == 1 && fcs2[0] == 0) || (asientos2[i] == 2 && fcs2[1] == 0) || (asientos2[i] == 3 && fcs2[2] == 0) || (asientos2[i] == 4 && fcs2[3] == 0) || (asientos2[i] == 5 && fcs2[4] == 0) || (asientos2[i] == 6 && fcs2[5] == 0) || (asientos2[i] == 7 && fcs2[6] == 0) || (asientos2[i] == 8 && fcs2[7] == 0))
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Esta fuera del rango o esta agotado vuelva a intentarlo");
                        Console.Write("Elija el asiento que desea: ");
                        asientos2[i] = int.Parse(Console.ReadLine());
                    }
                    while ((asientos2[i] == 9 && fcs2[8] == 0) || (asientos2[i] == 10 && fcs2[9] == 0) || (asientos2[i] == 11 && fcs2[10] == 0) || (asientos2[i] == 12 && fcs2[11] == 0) || (asientos2[i] == 13 && fcs2[12] == 0) || (asientos2[i] == 14 && fcs2[13] == 0) || (asientos2[i] == 15 && fcs2[14] == 0) || (asientos2[i] == 16 && fcs2[15] == 0))
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Esta fuera del rango o esta agotado vuelva a intentarlo");
                        Console.Write("Elija el asiento que desea: ");
                        asientos2[i] = int.Parse(Console.ReadLine());
                    }
                    Console.Clear();

                    if (asientos2[i] == 1 && fcs2[0] == 1)
                    {
                        fcs2[0] = 0;

                    }
                    if (asientos2[i] == 2 && fcs2[1] == 2)
                    {
                        fcs2[1] = 0;
                    }
                    if (asientos2[i] == 3 && fcs2[2] == 3)
                    {
                        fcs2[2] = 0;

                    }
                    if (asientos2[i] == 4 && fcs2[3] == 4)
                    {
                        fcs2[3] = 0;

                    }
                    if (asientos2[i] == 5 && fcs2[4] == 5)
                    {
                        fcs2[4] = 0;

                    }
                    if (asientos2[i] == 6 && fcs2[5] == 6)
                    {

                        fcs2[5] = 0;
                    }
                    if (asientos2[i] == 7 && fcs2[6] == 7)
                    {
                        fcs2[6] = 0;

                    }
                    if (asientos2[i] == 8 && fcs2[7] == 8)
                    {
                        fcs2[7] = 0;

                    }
                    if (asientos2[i] == 9 && fcs2[8] == 9)
                    {
                        fcs2[8] = 0;

                    }
                    if (asientos2[i] == 10 && fcs2[9] == 10)
                    {
                        fcs2[9] = 0;

                    }
                    if (asientos2[i] == 11 && fcs2[10] == 11)
                    {
                        fcs2[10] = 0;

                    }
                    if (asientos2[i] == 12 && fcs2[11] == 12)
                    {
                        fcs2[11] = 0;

                    }
                    if (asientos2[i] == 13 && fcs2[12] == 13)
                    {
                        fcs2[12] = 0;

                    }
                    if (asientos2[i] == 14 && fcs2[13] == 14)
                    {
                        fcs2[13] = 0;

                    }
                    if (asientos2[i] == 15 && fcs2[14] == 15)
                    {
                        fcs2[14] = 0;

                    }
                    if (asientos2[i] == 16 && fcs2[15] == 16)
                    {
                        fcs2[15] = 0;

                    }
                }
                else
                {
                    Console.ReadKey();
                }
            }
            Console.WriteLine("\n");

            for (int i = 0; i < tic2; i++)
            {
                Console.Write("\t" + asientos2[i]);
            }
            Console.WriteLine("\n");
            Console.ReadKey();
            return sum2;
        }
        public static void PantallaSala2(int[,] matriz)
        {
            var filas = matriz.GetLength(0);
            var columnas = matriz.GetLength(1);
            var sb = new StringBuilder();
            var tmpfila = new int[matriz.GetLength(0)];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    tmpfila[j] = matriz[i, j];
                }
                sb.AppendLine(string.Join("\t", tmpfila));
                sb.AppendLine("");
            }
            Console.WriteLine(sb.ToString());

        }
        //Fin Sala 2
        //Inicio de sala 3
        static int Sala3(int[] fcs3, int sum3)
        {
            Console.Clear();
            int tic3;
            int dis = 16 - sum3;
            int[] asientos3 = new int[20];
            Console.WriteLine("Usted a seleccinado la Sala 3 - Star Wars : La Amenaza Fantasma");
            Console.WriteLine("¿Cuántas entradas desea comprar?");
            tic3 = int.Parse(Console.ReadLine());

            while (tic3 > dis || tic3 < 1)
            {
                Console.WriteLine("La cantidad ingresada supera los asientos disponibles o el valor no es valido");
                Console.WriteLine("Asientos disponibles {0}", dis);
                Console.WriteLine("Vuelva a hacer su pedido en ese rango");
                Console.WriteLine("¿Cuántas entradas desea comprar?");
                tic3 = int.Parse(Console.ReadLine());
            }

            sum3 = sum3 + tic3;
            Console.WriteLine("Asientos ocupados son: " + sum3);
            Console.WriteLine("Asientos disponibles son: " + (dis - tic3));
            Console.WriteLine("Usted a seleccionado {0} asientos", tic3);
            Console.WriteLine("\n");

            for (int i = 0; i <= tic3; i++)
            {
                int[,] sal3 = new int[4, 4]
                 {
                     {fcs3[0],fcs3[1],fcs3[2],fcs3[3]},{fcs3[4],fcs3[5],fcs3[6],fcs3[7]},
                     {fcs3[8],fcs3[9],fcs3[10],fcs3[11]},{fcs3[12],fcs3[13],fcs3[14],fcs3[15]}
                 };
                PantallaSala3(sal3);
                Console.WriteLine("\n");
                if (i < tic3)
                {
                    Console.Write("Elija el asiento que desea: ");
                    asientos3[i] = int.Parse(Console.ReadLine());
                    while (asientos3[i] <= 0 || asientos3[i] > 16)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Esta fuera del rango o esta agotado vuelva a intentarlo");
                        Console.Write("Elija el asiento que desea: ");
                        asientos3[i] = int.Parse(Console.ReadLine());
                    }
                    while ((asientos3[i] == 1 && fcs3[0] == 0) || (asientos3[i] == 2 && fcs3[1] == 0) || (asientos3[i] == 3 && fcs3[2] == 0) || (asientos3[i] == 4 && fcs3[3] == 0) || (asientos3[i] == 5 && fcs3[4] == 0) || (asientos3[i] == 6 && fcs3[5] == 0) || (asientos3[i] == 7 && fcs3[6] == 0) || (asientos3[i] == 8 && fcs3[7] == 0))
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Esta fuera del rango o esta agotado vuelva a intentarlo");
                        Console.Write("Elija el asiento que desea: ");
                        asientos3[i] = int.Parse(Console.ReadLine());
                    }
                    while ((asientos3[i] == 9 && fcs3[8] == 0) || (asientos3[i] == 10 && fcs3[9] == 0) || (asientos3[i] == 11 && fcs3[10] == 0) || (asientos3[i] == 12 && fcs3[11] == 0) || (asientos3[i] == 13 && fcs3[12] == 0) || (asientos3[i] == 14 && fcs3[13] == 0) || (asientos3[i] == 15 && fcs3[14] == 0) || (asientos3[i] == 16 && fcs3[15] == 0))
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Esta fuera del rango o esta agotado vuelva a intentarlo");
                        Console.Write("Elija el asiento que desea: ");
                        asientos3[i] = int.Parse(Console.ReadLine());
                    }
                    Console.Clear();

                    if (asientos3[i] == 1 && fcs3[0] == 1)
                    {
                        fcs3[0] = 0;

                    }
                    else if (asientos3[i] == 2 && fcs3[1] == 2)
                    {
                        fcs3[1] = 0;
                    }
                    else if (asientos3[i] == 3 && fcs3[2] == 3)
                    {
                        fcs3[2] = 0;

                    }
                    else if (asientos3[i] == 4 && fcs3[3] == 4)
                    {
                        fcs3[3] = 0;

                    }
                    else if (asientos3[i] == 5 && fcs3[4] == 5)
                    {
                        fcs3[4] = 0;

                    }
                    else if (asientos3[i] == 6 && fcs3[5] == 6)
                    {

                        fcs3[5] = 0;
                    }
                    else if (asientos3[i] == 7 && fcs3[6] == 7)
                    {
                        fcs3[6] = 0;

                    }
                    else if (asientos3[i] == 8 && fcs3[7] == 8)
                    {
                        fcs3[7] = 0;

                    }
                    else if (asientos3[i] == 9 && fcs3[8] == 9)
                    {
                        fcs3[8] = 0;

                    }
                    else if (asientos3[i] == 10 && fcs3[9] == 10)
                    {
                        fcs3[9] = 0;

                    }
                    else if (asientos3[i] == 11 && fcs3[10] == 11)
                    {
                        fcs3[10] = 0;

                    }
                    else if (asientos3[i] == 12 && fcs3[11] == 12)
                    {
                        fcs3[11] = 0;

                    }
                    else if (asientos3[i] == 13 && fcs3[12] == 13)
                    {
                        fcs3[12] = 0;

                    }
                    else if (asientos3[i] == 14 && fcs3[13] == 14)
                    {
                        fcs3[13] = 0;

                    }
                    else if (asientos3[i] == 15 && fcs3[14] == 15)
                    {
                        fcs3[14] = 0;

                    }
                    else if (asientos3[i] == 16 && fcs3[15] == 16)
                    {
                        fcs3[15] = 0;

                    }
                }
                else
                {
                    Console.ReadKey();
                }
            }

            Console.WriteLine("\n");

            for (int i = 0; i < tic3; i++)
            {
                Console.Write("\t" + asientos3[i]);
            }
            Console.WriteLine("\n");
            Console.ReadKey();
            return sum3;
        }
        public static void PantallaSala3(int[,] matriz)
        {
            var filas = matriz.GetLength(0);
            var columnas = matriz.GetLength(1);
            var sb = new StringBuilder();
            var tmpfila = new int[matriz.GetLength(0)];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    tmpfila[j] = matriz[i, j];
                }
                sb.AppendLine(string.Join("\t", tmpfila));
                sb.AppendLine("");
            }
            Console.WriteLine(sb.ToString());
        }
        //sala 4
        static int Sala4(int[] fcs4, int sum4)
        {
            Console.Clear();
            int tic4;
            int dis = 16 - sum4;
            int[] asientos4 = new int[20];
            Console.WriteLine("Usted a seleccinado la Sala 4 - Toy Story 4");
            Console.WriteLine("¿Cuántas entradas desea comprar?");
            tic4 = int.Parse(Console.ReadLine());

            while (tic4 > dis || tic4 < 1)
            {
                Console.WriteLine("La cantidad ingresada supera los asientos disponibles o el valor no es valido");
                Console.WriteLine("Asientos disponibles {0}", dis);
                Console.WriteLine("Vuelva a hacer su pedido en ese rango");
                Console.WriteLine("¿Cuántas entradas desea comprar?");
                tic4 = int.Parse(Console.ReadLine());
            }

            sum4 = sum4 + tic4;
            Console.WriteLine("Asientos ocupados son: " + sum4);
            Console.WriteLine("Asientos disponibles son: " + (dis - tic4));
            Console.WriteLine("Usted a seleccionado {0} asientos", tic4);
            Console.WriteLine("\n");

            for (int i = 0; i <= tic4; i++)
            {
                int[,] sal4 = new int[4, 4]
                 {
                     {fcs4[0],fcs4[1],fcs4[2],fcs4[3]},{fcs4[4],fcs4[5],fcs4[6],fcs4[7]},
                     {fcs4[8],fcs4[9],fcs4[10],fcs4[11]},{fcs4[12],fcs4[13],fcs4[14],fcs4[15]}
                 };
                PantallaSala4(sal4);
                Console.WriteLine("\n");
                if (i < tic4)
                {
                    Console.Write("Elija el asiento que desea: ");
                    asientos4[i] = int.Parse(Console.ReadLine());
                    while (asientos4[i] <= 0 || asientos4[i] > 16)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Esta fuera del rango o esta agotado vuelva a intentarlo");
                        Console.Write("Elija el asiento que desea: ");
                        asientos4[i] = int.Parse(Console.ReadLine());
                    }
                    while ((asientos4[i] == 1 && fcs4[0] == 0) || (asientos4[i] == 2 && fcs4[1] == 0) || (asientos4[i] == 3 && fcs4[2] == 0) || (asientos4[i] == 4 && fcs4[3] == 0) || (asientos4[i] == 5 && fcs4[4] == 0) || (asientos4[i] == 6 && fcs4[5] == 0) || (asientos4[i] == 7 && fcs4[6] == 0) || (asientos4[i] == 8 && fcs4[7] == 0))
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Esta fuera del rango o esta agotado vuelva a intentarlo");
                        Console.Write("Elija el asiento que desea: ");
                        asientos4[i] = int.Parse(Console.ReadLine());
                    }
                    while ((asientos4[i] == 9 && fcs4[8] == 0) || (asientos4[i] == 10 && fcs4[9] == 0) || (asientos4[i] == 11 && fcs4[10] == 0) || (asientos4[i] == 12 && fcs4[11] == 0) || (asientos4[i] == 13 && fcs4[12] == 0) || (asientos4[i] == 14 && fcs4[13] == 0) || (asientos4[i] == 15 && fcs4[14] == 0) || (asientos4[i] == 16 && fcs4[15] == 0))
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Esta fuera del rango o esta agotado vuelva a intentarlo");
                        Console.Write("Elija el asiento que desea: ");
                        asientos4[i] = int.Parse(Console.ReadLine());
                    }
                    Console.Clear();

                    if (asientos4[i] == 1 && fcs4[0] == 1)
                    {
                        fcs4[0] = 0;

                    }
                    else if (asientos4[i] == 2 && fcs4[1] == 2)
                    {
                        fcs4[1] = 0;
                    }
                    else if (asientos4[i] == 3 && fcs4[2] == 3)
                    {
                        fcs4[2] = 0;

                    }
                    else if (asientos4[i] == 4 && fcs4[3] == 4)
                    {
                        fcs4[3] = 0;

                    }
                    else if (asientos4[i] == 5 && fcs4[4] == 5)
                    {
                        fcs4[4] = 0;

                    }
                    else if (asientos4[i] == 6 && fcs4[5] == 6)
                    {

                        fcs4[5] = 0;
                    }
                    else if (asientos4[i] == 7 && fcs4[6] == 7)
                    {
                        fcs4[6] = 0;

                    }
                    else if (asientos4[i] == 8 && fcs4[7] == 8)
                    {
                        fcs4[7] = 0;

                    }
                    else if (asientos4[i] == 9 && fcs4[8] == 9)
                    {
                        fcs4[8] = 0;

                    }
                    else if (asientos4[i] == 10 && fcs4[9] == 10)
                    {
                        fcs4[9] = 0;

                    }
                    else if (asientos4[i] == 11 && fcs4[10] == 11)
                    {
                        fcs4[10] = 0;

                    }
                    else if (asientos4[i] == 12 && fcs4[11] == 12)
                    {
                        fcs4[11] = 0;

                    }
                    else if (asientos4[i] == 13 && fcs4[12] == 13)
                    {
                        fcs4[12] = 0;

                    }
                    else if (asientos4[i] == 14 && fcs4[13] == 14)
                    {
                        fcs4[13] = 0;

                    }
                    else if (asientos4[i] == 15 && fcs4[14] == 15)
                    {
                        fcs4[14] = 0;

                    }
                    else if (asientos4[i] == 16 && fcs4[15] == 16)
                    {
                        fcs4[15] = 0;

                    }
                }
                else
                {
                    Console.ReadKey();
                }
            }
            Console.WriteLine("\n");

            for (int i = 0; i < tic4; i++)
            {
                Console.Write("\t" + asientos4[i]);
            }
            Console.WriteLine("\n");
            Console.ReadKey();
            return sum4;
        }
        public static void PantallaSala4(int[,] matriz)
        {
            var filas = matriz.GetLength(0);
            var columnas = matriz.GetLength(1);
            var sb = new StringBuilder();
            var tmpfila = new int[matriz.GetLength(0)];
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    tmpfila[j] = matriz[i, j];
                }
                sb.AppendLine(string.Join("\t", tmpfila));
                sb.AppendLine("");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}