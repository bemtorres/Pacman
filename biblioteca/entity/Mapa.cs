using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace biblioteca.entity
{
    public class Mapa
    {
        public static String[,] fondo() {
            String[,] matriz = new String[31, 28];
            for (int i = 0; i < 31; i++)
            {
                for (int j = 0; j < 28; j++)
                {
                    matriz[i, j] = ".";
                    if (i == 0 || i == 30)
                    {
                        matriz[i, j] = "=";
                    }
                    if (j == 0 || j == 27)
                    {
                        matriz[i, j] = "|";
                    }

                    #region LIMITES EN BLANCO
                    //limites de blanco

                    if (i == 3 && j >= 3 && j <= 4 || i == 3 && j >= 8 && j <= 10 || i == 3 && j >= 17 && j <= 19 || i == 3 && j >= 23 && j <= 24)
                    {
                        matriz[i, j] = " ";
                    }
                    if (i == 9 && j == 12 || i == 9 && j == 15)
                    {
                        matriz[i, j] = " ";
                    }
                    if (i == 10 && j >= 0 && j <= 4 || i == 10 && j == 12 || i == 10 && j == 15 || i == 10 && j >= 23 && j <= 27)
                    {
                        matriz[i, j] = " ";
                    }
                    if (i == 11 && j >= 0 && j <= 4 || i == 11 && j >= 9 && j <= 18 || i == 11 && j >= 23 && j <= 27)
                    {
                        matriz[i, j] = " ";
                    }
                    if (i == 12 && j >= 0 && j <= 4 || i == 12 && j >= 9 && j <= 18 || i == 12 && j >= 23 && j <= 27)
                    {
                        matriz[i, j] = " ";
                    }
                    if (i == 13 && j == 9 || i == 13 && j >= 13 && j <= 14 || i == 13 && j == 18)
                    {
                        matriz[i, j] = " ";
                    }
                    if (i == 14 && j >= 0 && j <= 5 || i == 14 && j >= 7 && j <= 9 || i == 14 && j >= 11 && j <= 16 || i == 14 && j >= 18 && j <= 20 || i == 14 && j >= 22 && j <= 27)
                    {
                        matriz[i, j] = " ";
                    }
                    if (i == 15 && j == 9 || i == 15 && j >= 11 && j <= 16 || i == 15 && j == 18)
                    {
                        matriz[i, j] = " ";
                    }
                    if (i == 16 && j >= 0 && j <= 4 || i == 16 && j == 9 || i == 16 && j == 18 || i == 16 && j >= 23 && j <= 27)
                    {
                        matriz[i, j] = " ";
                    }
                    if (i == 17 && j >= 0 && j <= 4 || i == 17 && j >= 9 && j <= 18 || i == 17 && j >= 23 && j <= 27)
                    {
                        matriz[i, j] = " ";
                    }
                    if (i == 18 && j >= 0 && j <= 4 || i == 18 && j == 9 || i == 18 && j == 18 || i == 18 && j >= 23 && j <= 27)
                    {
                        matriz[i, j] = " ";
                    }
                    if (i == 19 && j == 9 || i == 19 && j == 18)
                    {
                        matriz[i, j] = " ";
                    }
                    if (i == 13)
                    {
                        if (j == 11 || j == 12 || j == 15 || j == 16)
                        {
                            matriz[i, j] = " ";
                        }

                    }
                    if (i == 23)
                    {
                        if (j == 13 || j == 14)
                        {
                            matriz[i, j] = " ";
                        }
                    }
                    #endregion
                    #region LIMITES VERTICALES
                    // LIMITES VERTICALES
                    if (i == 1 && j == 13 || i == 1 && j == 14)
                    {
                        matriz[i, j] = "|";
                    }
                    if (i == 2 && j == 13 || i == 2 && j == 14)
                    {
                        matriz[i, j] = "|";
                    }
                    if (i == 3 && j == 2 || i == 3 && j == 5 || i == 3 && j == 7 || i == 3 && j == 11 || i == 3 && j == 13 || i == 3 && j == 14 || i == 3 && j == 16 || i == 3 && j == 20 || i == 3 && j == 22 || i == 3 && j == 25)
                    {
                        matriz[i, j] = "|";
                    }
                    if (i == 7 && j == 7 || i == 7 && j == 8 || i == 7 && j == 19 || i == 7 && j == 20)
                    {
                        matriz[i, j] = "|";
                    }
                    if (i == 8 && j == 7 || i == 8 && j == 8 || i == 8 && j == 13 || i == 8 && j == 14 || i == 8 && j == 19 || i == 8 && j == 20)
                    {
                        matriz[i, j] = "|";
                    }
                    if (i == 9 && j == 7 || i == 9 && j == 8 || i == 9 && j == 13 || i == 9 && j == 14 || i == 9 && j == 19 || i == 9 && j == 20)
                    {
                        matriz[i, j] = "|";
                    }
                    if (i == 10 && j == 5 || i == 10 && j == 7 || i == 10 && j == 8 || i == 10 && j == 19 || i == 10 && j == 20 || i == 10 && j == 22)
                    {
                        matriz[i, j] = "|";
                    }
                    if (i == 11 && j == 5 || i == 11 && j == 7 || i == 11 && j == 8 || i == 11 && j == 19 || i == 11 && j == 20 || i == 11 && j == 22)
                    {
                        matriz[i, j] = "|";
                    }
                    if (i == 12 && j == 5 || i == 12 && j == 7 || i == 12 && j == 8 || i == 12 && j == 19 || i == 12 && j == 20 || i == 12 && j == 22)
                    {
                        matriz[i, j] = "|";
                    }
                    if (i == 13)
                    {
                        if (j == 10 || j == 17)
                        {
                            matriz[i, j] = "|";
                        }
                    }
                    if (i == 14 && j == 10 || i == 14 && j == 17)
                    {
                        matriz[i, j] = "|";
                    }
                    if (i == 15 && j == 7 || i == 15 && j == 8 || i == 15 && j == 10 || i == 15 && j == 17 || i == 15 && j == 19 || i == 15 && j == 20)
                    {
                        matriz[i, j] = "|";
                    }
                    if (i == 16 && j == 5 || i == 16 && j == 7 || i == 16 && j == 8 || i == 16 && j == 19 || i == 16 && j == 20 || i == 16 && j == 22)
                    {
                        matriz[i, j] = "|";
                    }
                    if (i == 17 && j == 5 || i == 17 && j == 7 || i == 17 && j == 8 || i == 17 && j == 19 || i == 17 && j == 20 || i == 17 && j == 22)
                    {
                        matriz[i, j] = "|";
                    }
                    if (i == 18 && j == 5 || i == 18 && j == 7 || i == 18 && j == 8 || i == 18 && j == 19 || i == 18 && j == 20 || i == 18 && j == 22)
                    {
                        matriz[i, j] = "|";
                    }
                    if (i == 19)
                    {
                        if (j == 7 || j == 8 || j == 19 || j == 20)
                        {
                            matriz[i, j] = "|";
                        }
                    }
                    if (i == 20)
                    {
                        if (j == 13 || j == 14)
                        {
                            matriz[i, j] = "|";
                        }
                    }
                    if (i == 21)
                    {
                        if (j == 13 || j == 14)
                        {
                            matriz[i, j] = "|";
                        }
                    }
                    if (i == 23)
                    {
                        if (j == 4 || j == 5 || j == 22 || j == 23)
                        {
                            matriz[i, j] = "|";
                        }
                    }
                    if (i == 24)
                    {
                        if (j == 0 || j == 4 || j == 5 || j == 7 || j == 8 || j == 19 || j == 20 || j == 22 || j == 23 || j == 27)
                        {
                            matriz[i, j] = "|";
                        }
                    }
                    if (i == 25)
                    {
                        if (j == 4 || j == 5 || j == 7 || j == 8 || j == 19 || j == 20 || j == 22 || j == 23)
                        {
                            matriz[i, j] = "|";
                        }
                    }
                    if (i == 26)
                    {
                        if (j == 7 || j == 8 || j == 13 || j == 14 || j == 19 || j == 20)
                        {
                            matriz[i, j] = "|";
                        }
                    }
                    if (i == 27)
                    {
                        if (j == 13 || j == 14)
                        {
                            matriz[i, j] = "|";
                        }
                    }
                    if (i == 28)
                    {
                        if (j == 13 || j == 14)
                        {
                            matriz[i, j] = "|";
                        }
                    }
                    #endregion
                    #region LIMITES HORIZONTALES
                    // HORIZONTAL

                    if (i == 2)
                    {
                        if (j >= 2 && j <= 5 || j >= 7 && j <= 11 || j >= 16 && j <= 20 || j >= 22 && j <= 25)
                        {
                            matriz[i, j] = "-";
                        }
                    }
                    if (i == 4)
                    {
                        if (j >= 2 && j <= 5 || j >= 7 && j <= 11 || j >= 13 && j <= 14 || j >= 16 && j <= 20 || j >= 22 && j <= 25)
                        {
                            matriz[i, j] = "-";
                        }
                    }
                    if (i == 6)
                    {
                        if (j >= 2 && j <= 5 || j >= 7 && j <= 8 || j >= 19 && j <= 20 || j >= 22 && j <= 25 || j >= 10 && j <= 17)
                        {
                            matriz[i, j] = "-";
                        }
                    }
                    if (i == 7)
                    {
                        if (j >= 2 && j <= 5 || j >= 10 && j <= 17 || j >= 22 && j <= 25)
                        {
                            matriz[i, j] = "-";
                        }
                    }
                    if (i == 9)
                    {
                        if (j >= 0 && j <= 5 || j >= 9 && j <= 11 || j >= 16 && j <= 18 || j >= 22 && j <= 27)
                        {
                            matriz[i, j] = "-";
                        }
                    }
                    if (i == 10)
                    {
                        if (j >= 9 && j <= 11 || j >= 13 && j <= 14 || j >= 16 && j <= 18)
                        {
                            matriz[i, j] = "-";
                        }
                    }
                    if (i == 13)
                    {
                        if (j >= 0 && j <= 5 || j >= 7 && j <= 8 || j >= 19 && j <= 20 || j >= 22 && j <= 27)
                        {
                            matriz[i, j] = "-";
                        }
                    }
                    if (i == 12)
                    {
                        if (j >= 10 && j <= 12 || j >= 15 && j <= 17)
                        {
                            matriz[i, j] = "-";
                        }
                        if (j == 13 || j == 14)
                        {
                            matriz[i, j] = "-";
                        }
                    }
                    if (i == 15)
                    {
                        if (j >= 0 && j <= 5 || j >= 22 && j <= 27)
                        {
                            matriz[i, j] = "-";
                        }
                    }
                    if (i == 16)
                    {
                        if (j >= 10 && j <= 17)
                        {
                            matriz[i, j] = "-";
                        }
                    }
                    if (i == 18)
                    {
                        if (j >= 10 && j <= 17)
                        {
                            matriz[i, j] = "-";
                        }
                    }
                    if (i == 19)
                    {
                        if (j >= 0 && j <= 5 || j >= 10 && j <= 17 || j >= 22 && j <= 27)
                        {
                            matriz[i, j] = "-";
                        }
                    }
                    if (i == 21)
                    {
                        if (j >= 2 && j <= 5 || j >= 7 && j <= 11 || j >= 16 && j <= 20 || j >= 22 && j <= 25)
                        {
                            matriz[i, j] = "-";
                        }
                    }
                    if (i == 22)
                    {
                        if (j >= 2 && j <= 5 || j >= 7 && j <= 11 || j >= 13 && j <= 14 || j >= 16 && j <= 20 || j >= 22 && j <= 25)
                        {
                            matriz[i, j] = "-";
                        }
                    }
                    if (i == 24)
                    {
                        if (j >= 1 && j <= 2 || j >= 10 && j <= 17 || j >= 25 && j <= 26)
                        {
                            matriz[i, j] = "-";
                        }
                    }
                    if (i == 25)
                    {
                        if (j >= 1 && j <= 2 || j >= 10 && j <= 17 || j >= 25 && j <= 26)
                        {
                            matriz[i, j] = "-";
                        }
                    }
                    if (i == 27)
                    {
                        if (j >= 2 && j <= 11 || j >= 16 && j <= 25)
                        {
                            matriz[i, j] = "-";
                        }
                    }
                    if (i == 28)
                    {
                        if (j >= 2 && j <= 11 || j >= 16 && j <= 25)
                        {
                            matriz[i, j] = "-";
                        }
                    }
                    #endregion
                    #region BONOS
                    //BONO BALL
                    if (i == 3 && j == 1 || i == 3 && j == 26 || i == 23 && j == 1 || i == 23 && j == 26)
                    {
                        matriz[i, j] = "x";
                    }
                    #endregion                    
                    #region POSICION INICIAL ENEMIGO
                    //ENEMIGO
                    if (i == 11 && j == 13)
                    {
                        matriz[i, j] = "R";
                    }
                    if (i == 14 && j == 12)
                    {
                        matriz[i, j] = "P";
                    }
                    if (i == 15 && j == 15)
                    {
                        matriz[i, j] = "C";
                    }
                    if (i == 13 && j == 15)
                    {
                        matriz[i, j] = "N";
                    }
                    #endregion
                    //JUGADOR
                    if (i == 23 && j == 13)
                    {
                        matriz[i, j] = ">";
                    }

                }
            }
            return matriz;
        }
        public static String[,] comida(String[,] mapa) {
            String[,] matrizComida = new String[31, 28];
            for (int i = 0; i < 31; i++)
            {
                for (int j = 0; j < 28; j++)
                {
                    if (mapa[i, j].Equals("."))
                    {
                        matrizComida[i, j] = mapa[i, j];
                    }
                    else {
                        matrizComida[i, j] = "";
                    }
                }
            }
            return matrizComida;
        }
        public static void imprimir(String[,] matriz) {
            Console.Clear();
            for (int i = 0; i < 31; i++)
            {
                for (int j = 0; j < 28; j++)
                {
                    if (matriz[i, j] == "x")
                    {
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
        public static void agregarJugador() {
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
        public static void imprimirPuntajes(JugadorColeccion jugadores) {
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
                Console.WriteLine("             "+xx.nombre + "                       " + xx.puntaje);
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

        public static int[] buscarPlayer(String[,] matriz) {
            int[] posicion= new int[2];
            for (int i = 0; i < 31; i++)
            {
                for (int j = 0; j < 28; j++)
                {
                    if (matriz[i, j] == "<" || matriz[i, j] == ">" || matriz[i, j] == "V" || matriz[i, j] == "^")
                    {
                        posicion[0] = i;
                        posicion[1] = j;
                    }
                }
            }

            return posicion;
        }




        public static void exit() {            
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
