using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace biblioteca.entity
{
    public class Pantalla
    {
        public static void start()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("2017");
            Console.WriteLine("           _ __   __ _  ___ _ __ ___   __ _ _ ___ ");
            Console.WriteLine("          |  _ | / _` |/ __|  _   _ | / _` |  _  |");
            Console.WriteLine("          | |_) | (_| | (__| | | | | | (_| | | | |");
            Console.WriteLine("          | .__/  __,_| ___|_| |_| |_| __,_|_| |_|");
            Console.WriteLine("          |_| ");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                    by Benjamin Mora");
            Console.ForegroundColor = ConsoleColor.Cyan; ;
            Console.WriteLine("");
            Console.WriteLine("@=========================================================@");
            Console.Write("       .-. ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("          P ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" A ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" C ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" M ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" A ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(" N            ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(".-.    ");
            Console.WriteLine("      | OO|                                     | OO|   ");
            Console.WriteLine("      |   |                                     |   |   ");
            Console.WriteLine("       ^^^                                       ^^^    ");
            Console.WriteLine("==========================================================");
            Thread.Sleep(200);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                      Presione una tecla para continuar...");
            Console.ReadKey();
        }       
        public static void menu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                         MENU");
            Console.WriteLine("           _ __   __ _  ___ _ __ ___   __ _ _ ___ ");
            Console.WriteLine("          |  _ | / _` |/ __|  _   _ | / _` |  _  |");
            Console.WriteLine("          | |_) | (_| | (__| | | | | | (_| | | | |");
            Console.WriteLine("          | .__/  __,_| ___|_| |_| |_| __,_|_| |_|");
            Console.WriteLine("          |_| ");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                    by Benjamin Mora");
            Console.ForegroundColor = ConsoleColor.Cyan; ;
            Console.WriteLine("");
            Console.WriteLine("@=========================================================@");
            Console.Write("       .-.           ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("  1.- Jugar ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("                .-.    ");
            Console.Write("      | OO|   ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("         2.- Tabla de puntajes");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("    | OO|   ");
            Console.Write("      |   |            ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("3.- Creditos");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("             |   |   ");
            Console.WriteLine("       ^^^             4.- Salir                 ^^^    ");
            Console.WriteLine("==========================================================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("               Elija una opcion...");
        }
        public static void imprimirPuntajes(JugadorColeccion jugadores)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                   TABLA DE PUNTAJES");
            Console.WriteLine("           _ __   __ _  ___ _ __ ___   __ _ _ ___ ");
            Console.WriteLine("          |  _ | / _` |/ __|  _   _ | / _` |  _  |");
            Console.WriteLine("          | |_) | (_| | (__| | | | | | (_| | | | |");
            Console.WriteLine("          | .__/  __,_| ___|_| |_| |_| __,_|_| |_|");
            Console.WriteLine("          |_| ");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                    by Benjamin Mora");
            Console.ForegroundColor = ConsoleColor.Cyan; ;
            Console.WriteLine("");
            Console.WriteLine("@=========================================================@");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("              Nombre                  Puntaje");
            foreach (Jugador xx in jugadores.listar())
            {
                Console.WriteLine("             " + xx.nombre + "                       " + xx.puntaje);
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("       .-.                                       .-. ");
            Console.WriteLine("      | OO|                                     | OO|   ");
            Console.WriteLine("      |   |                                     |   |   ");
            Console.WriteLine("       ^^^                                       ^^^    ");
            Console.WriteLine("==========================================================");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                      Presione una tecla volver al menu");
            Console.ReadKey();
        }
        public static void agregarJugador()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                   Empezar");
            Console.WriteLine("           _ __   __ _  ___ _ __ ___   __ _ _ ___ ");
            Console.WriteLine("          |  _ | / _` |/ __|  _   _ | / _` |  _  |");
            Console.WriteLine("          | |_) | (_| | (__| | | | | | (_| | | | |");
            Console.WriteLine("          | .__/  __,_| ___|_| |_| |_| __,_|_| |_|");
            Console.WriteLine("          |_| ");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                    by Benjamin Mora");
            Console.ForegroundColor = ConsoleColor.Cyan; ;
            Console.WriteLine("");
            Console.WriteLine("@=========================================================@");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("              Ingrese su nombre");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("       .-.                                       .-. ");
            Console.WriteLine("      | OO|                                     | OO|   ");
            Console.WriteLine("      |   |                                     |   |   ");
            Console.WriteLine("       ^^^                                       ^^^    ");
            Console.WriteLine("==========================================================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                      ");
        }
        public static void imprimir(String[,] matriz)
        {
            Console.Clear();
            for (int i = 0; i < 31; i++)
            {
                for (int j = 0; j < 28; j++)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    if (matriz[i, j] == "-" || matriz[i, j] == "|" || matriz[i, j] == "=" || matriz[i, j] == "#" || matriz[i, j] == "_")
                    {
                       // Console.BackgroundColor = ConsoleColor.Cyan;

                    }
                    if (matriz[i, j] == "x")                    {
                        
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" " + matriz[i, j]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    else
                    {
                        if (matriz[i, j] == ".")
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(" " + matriz[i, j]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            if (matriz[i, j] == ">" || matriz[i, j] == "<" || matriz[i, j] == "V" || matriz[i, j] == "^")
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write(" " + matriz[i, j]);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                if (matriz[i, j] == "P")
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.Write(" " + matriz[i, j]);
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else
                                {
                                    if (matriz[i, j] == "R")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write(" " + matriz[i, j]);
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    else
                                    {
                                        if (matriz[i, j] == "C")
                                        {
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            Console.Write(" " + matriz[i, j]);
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                        else
                                        {
                                            if (matriz[i, j] == "N")
                                            {
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.Write(" " + matriz[i, j]);
                                                Console.ForegroundColor = ConsoleColor.White;
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.Write(" " + matriz[i, j]);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                Console.WriteLine("");
            }
        }
        public static void imprimirFusion(String[,] matriz, String[,] matrizComida)
        {
            Console.Clear();
            for (int i = 0; i < 31; i++)
            {
                for (int j = 0; j < 28; j++)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    if (matriz[i, j] == "-" || matriz[i, j] == "|" || matriz[i, j] == "=" || matriz[i, j] == "#" || matriz[i, j] == "_")
                    {
                        // Console.BackgroundColor = ConsoleColor.Cyan;

                    }
                    if (matriz[i, j] == "x")
                    {

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(" " + matriz[i, j]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    else
                    {
                        if (matrizComida[i, j] == ".")
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(" " + matriz[i, j]);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            if (matriz[i, j] == ">" || matriz[i, j] == "<" || matriz[i, j] == "V" || matriz[i, j] == "^")
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write(" " + matriz[i, j]);
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            else
                            {
                                if (matriz[i, j] == "P")
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.Write(" " + matriz[i, j]);
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else
                                {
                                    if (matriz[i, j] == "R")
                                    {
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.Write(" " + matriz[i, j]);
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    else
                                    {
                                        if (matriz[i, j] == "C")
                                        {
                                            Console.ForegroundColor = ConsoleColor.Gray;
                                            Console.Write(" " + matriz[i, j]);
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                        else
                                        {
                                            if (matriz[i, j] == "N")
                                            {
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.Write(" " + matriz[i, j]);
                                                Console.ForegroundColor = ConsoleColor.White;
                                            }
                                            else
                                            {
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.Write(" " + matriz[i, j]);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                Console.WriteLine("");
            }
        }
        public static void exit()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("     Muchas Gracias  ");
            Console.WriteLine("     ");
            Console.WriteLine("");
            Console.WriteLine("                 Fin del escenario ");
            Console.WriteLine("           _ __   __ _  ___ _ __ ___   __ _ _ ___ ");
            Console.WriteLine("          |  _ | / _` |/ __|  _   _ | / _` |  _  |");
            Console.WriteLine("          | |_) | (_| | (__| | | | | | (_| | | | |");
            Console.WriteLine("          | .__/  __,_| ___|_| |_| |_| __,_|_| |_|");
            Console.WriteLine("          |_| ");
            Console.WriteLine("                             Programado por Benjamin Mora");
            Console.ReadKey();
        }
    }
}
