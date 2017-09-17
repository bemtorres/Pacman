using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OnlyLine
{
    class Program
    {
        static void Main(string[] args)
        {
            //Este es el proyecto que hice en marzo 2017

            string[,] matriz = new string[31, 28];
            bool vida = true, seMovio = false;
            int puntos = 0, contMove = 0, a = 0, b = 0, c = 0, d = 0;
            string opc = "";
            string[,] matrizPuntos = new string[31, 28]; //matriz que guardara la posicion 

            presentacion();


            //
            //  ********************************************
            //  *  G E N E R A D O R    D E    M A T R I Z *
            //  ********************************************
            //ok
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

            // PROCESO DEL JUEGO

            while (vida)
            {
                //  
                //
                //SALIDA DE VISTA
                //
                //ok
                #region IMPRESOR MATRIZ
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
                #endregion 

                //ok
                //
                //CADENA DE MANDO
                //
                //
                Console.WriteLine("< < < <                          PUNTOS " + puntos);
                Console.WriteLine("C O N T R O L E S                MOVIMIENTOS " + contMove);
                Console.WriteLine("                         [W]");
                Console.WriteLine("                     8.- ARRIBA");
                Console.WriteLine("    4.- IZQUIERDA [A]             6.- DERECHA [D]");
                Console.WriteLine("                     2.- ABAJO");
                Console.WriteLine("                          [S]");
                Console.WriteLine("");
                // do
                //{
                opc = Console.ReadLine();

                // } while (opc == "5" || opc == "4" || opc == "6" || opc == "8" || opc == "A" || opc == "S" || opc == "D" || opc == "W" || opc == "a" || opc == "s" || opc == "d" || opc == "w");

                //Console.WriteLine("eligio ");

                //  Console.ReadLine();
                //OK
                //BUSCA LA POSICION DEL JUGADOR Y LO GUARDA EN DOS VARIABLES
                #region BUSCAR PACMAN
                for (int i = 0; i < 31; i++)
                {
                    for (int j = 0; j < 28; j++)
                    {
                        if (matriz[i, j] == "<" || matriz[i, j] == ">" || matriz[i, j] == "V" || matriz[i, j] == "^")
                        {
                            a = i;
                            b = j;
                        }
                    }
                }
                #endregion
                // Ok
                for (int i = 0; i < 31; i++)
                {
                    for (int j = 0; j < 28; j++)
                    {
                        if (matriz[i, j] == ".")
                        {
                            matrizPuntos[i, j] = ".";
                        }
                        else
                        {
                            matrizPuntos[i, j] = " ";
                        }
                    }
                }
                //
                #region MOVIMIENTO ARRIBA JUGADOR
                //MOVIMIENTO ARRIBA

                if (opc == "8" || opc == "w" || opc == "W")
                {
                    c = a - 1;
                    d = b;
                    for (int i = 0; i < 30; i++)
                    {
                        for (int j = 0; j < 27; j++)
                        {
                            if (i == c && j == d)
                            {
                                if (matriz[i, j] == "-" || matriz[i, j] == "|" || matriz[i, j] == "=" || matriz[i, j] == "#" || matriz[i, j] == "_")
                                {
                                    Console.WriteLine("No se puede hacer ese movimiento.");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                else
                                {
                                    if (matriz[i, j] == "R" || matriz[i, j] == "P" || matriz[i, j] == "C" || matriz[i, j] == "N")
                                    {
                                        vida = false;
                                    }
                                    else
                                    {
                                        if (matriz[i, j] == ".")
                                        {
                                            puntos = puntos + 10;
                                        }
                                        if (matriz[i, j] == "x")
                                        {
                                            puntos = puntos + 100;
                                        }
                                        matriz[a, b] = " ";
                                        matriz[c, d] = "V";
                                        contMove = contMove + 1;
                                        seMovio = true;

                                    }
                                }
                            }
                        }
                    }
                }
                #endregion
                //
                #region MOVIMIENTO ABAJO JUGADOR
                if (opc == "S" || opc == "s" || opc == "5")
                {
                    c = a + 1;
                    d = b;
                    for (int i = 0; i < 30; i++)
                    {
                        for (int j = 0; j < 27; j++)
                        {
                            if (i == c && j == d)
                            {
                                if (matriz[i, j] == "-" || matriz[i, j] == "|" || matriz[i, j] == "=" || matriz[i, j] == "#" || matriz[i, j] == "_")
                                {
                                    Console.WriteLine("No se puede hacer ese movimiento.");
                                    Console.ReadLine();
                                    Console.Clear();
                                }
                                else
                                {
                                    if (matriz[i, j] == "R" || matriz[i, j] == "P" || matriz[i, j] == "C" || matriz[i, j] == "N")
                                    {
                                        vida = false;
                                    }
                                    else
                                    {
                                        if (matriz[i, j] == ".")
                                        {
                                            puntos = puntos + 10;
                                        }
                                        if (matriz[i, j] == "x")
                                        {
                                            puntos = puntos + 100;
                                        }
                                        matriz[a, b] = " ";
                                        matriz[c, d] = "^";
                                        contMove = contMove + 1;
                                        seMovio = true;
                                    }
                                }
                            }
                        }
                    }
                }
                #endregion
                //
                #region MOVIMIENTO IZQUIERDA JUGADOR
                //MOVER A LA IZQUIERDA
                if (opc == "a" || opc == "A" || opc == "4")
                {
                    c = a;
                    d = b - 1;
                    for (int i = 0; i < 31; i++)
                    {
                        for (int j = 0; j < 28; j++)
                        {

                            if (c == 14 && d == -1)
                            {
                                matriz[a, b] = " ";
                                matriz[14, 27] = ">";
                                //contMove = contMove + 1;                           
                            }
                            else
                            {
                                if (i == c && j == d)
                                {
                                    if (matriz[i, j] == "-" || matriz[i, j] == "|" || matriz[i, j] == "=" || matriz[i, j] == "#" || matriz[i, j] == "_")
                                    {
                                        Console.WriteLine("No se puede hacer ese movimiento.");
                                        Console.ReadLine();
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        if (matriz[i, j] == "R" || matriz[i, j] == "P" || matriz[i, j] == "C" || matriz[i, j] == "N")
                                        {
                                            vida = false;
                                        }
                                        else
                                        {
                                            if (matriz[i, j] == ".")
                                            {
                                                puntos = puntos + 10;
                                            }
                                            if (matriz[i, j] == "x")
                                            {
                                                puntos = puntos + 100;
                                            }
                                            matriz[a, b] = " ";
                                            matriz[c, d] = ">";
                                            contMove = contMove + 1;
                                            seMovio = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                #endregion
                //
                #region MOVIMIENTO DERECHA JUGADOR
                //MOVER A LA DERECHA
                if (opc == "D" || opc == "d" || opc == "6")
                {
                    c = a;
                    d = b + 1;
                    for (int i = 0; i < 31; i++)
                    {
                        for (int j = 0; j < 28; j++)
                        {

                            if (c == 14 && d == 28)
                            {
                                matriz[a, b] = " ";
                                matriz[14, 0] = "<";
                                // contMove = contMove + 1;
                            }
                            else
                            {
                                if (i == c && j == d)
                                {
                                    if (matriz[i, j] == "-" || matriz[i, j] == "|" || matriz[i, j] == "=" || matriz[i, j] == "#" || matriz[i, j] == "_")
                                    {
                                        Console.WriteLine("No se puede hacer ese movimiento.");
                                        Console.ReadLine();
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        if (matriz[i, j] == "R" || matriz[i, j] == "P" || matriz[i, j] == "C" || matriz[i, j] == "N")
                                        {
                                            vida = false;
                                        }
                                        else
                                        {
                                            if (matriz[i, j] == ".")
                                            {
                                                puntos = puntos + 10;
                                            }
                                            if (matriz[i, j] == "x")
                                            {
                                                puntos = puntos + 100;
                                            }
                                            matriz[a, b] = " ";
                                            matriz[c, d] = "<";
                                            contMove = contMove + 1;
                                            seMovio = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                #endregion
                // ----- FIN CONTROLES ---- 



                if (seMovio)
                {
                    seMovio = false;

                }


                Console.Clear();
            }  //salida de while

            if (!vida)
            {
                #region MENSAJE DE GAME OVER
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("     SUS PUNTAJE FUE DE " + puntos);
                Console.WriteLine("     MOVIMIENTOS ALCANZADOS " + contMove);
                Console.WriteLine("");
                Console.WriteLine("                 G a m e  O v e r ");
                Console.WriteLine("           _ __   __ _  ___ _ __ ___   __ _ _ ___ ");
                Console.WriteLine("          |  _ | / _` |/ __|  _   _ | / _` |  _  |");
                Console.WriteLine("          | |_) | (_| | (__| | | | | | (_| | | | |");
                Console.WriteLine("          | .__/  __,_| ___|_| |_| |_| __,_|_| |_|");
                Console.WriteLine("          |_| ");
                Console.WriteLine("                             Programado por Benjamin Mora");
                Console.ReadKey();
                #endregion
            }

        }

        static void presentacion()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("");
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
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                      Presione una tecla para continuar...");
            Console.ReadKey();
            Console.Clear();

        }
    }
}

