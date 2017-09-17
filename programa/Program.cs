﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using biblioteca.entity;
using biblioteca;

namespace programa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pacman: \"{0}\"",
                     Console.Title);
            JugadorColeccion jugadores = new JugadorColeccion();
            //Se crea el mapa
            String[,] matrizFondo = Mapa.fondo();
            // se crea la copia de ma
            String[,] matrizComida = Mapa.comida(matrizFondo);

            jugadores.llenar();            
            String opcion = "";

            Jugador player = new Jugador();
            int[] posicionPlayer = new int[2];
            bool play= true;
            bool vida = false;

            Mapa.start();
            while (play)
            {
                Mapa.menu();
                opcion = Console.ReadLine();
                if (opcion.Equals("1"))
                {
                    //imprime salida para agregar
                    Mapa.agregarJugador();
                    player.nombre = Console.ReadLine(); //pregunta nombre y lo agrega
                    player.puntaje = 0;
                    player.vida = 3;
                    player.contMovimiento = 0;                    
                    vida = jugadores.agregar(player); //incresa un nuevo jugador
                    posicionPlayer = Mapa.buscarPlayer(matrizFondo); // se busca la posicion del jugador para tenerla guardada
                }
                if (opcion.Equals("2"))
                {
                    Mapa.imprimirPuntajes(jugadores);
                }
                if (opcion.Equals("3"))
                {

                }
                if (opcion.Equals("4"))
                {
                    Mapa.exit();
                    vida = false;
                    play = false;
                }

                while (vida)
                {
                    Mapa.imprimir(matrizFondo);
                    //
                    //
                    //CADENA DE MANDO
                    //
                    //
                    Console.WriteLine("Vida"+player.vida+"                      PUNTOS " + player.puntaje);
                    Console.WriteLine("C O N T R O L E S                MOVIMIENTOS " + player.contMovimiento);
                    Console.WriteLine("                         [W]");
                    Console.WriteLine("                     8.- ARRIBA");
                    Console.WriteLine("    4.- IZQUIERDA [A]             6.- DERECHA [D]");
                    Console.WriteLine("                     2.- ABAJO");
                    Console.WriteLine("                          [S]");
                    Console.WriteLine("");


                    opcion = Console.ReadLine();
                    ///Mapa.movimieto(String opcion);
                   
                }
            }
           





            Mapa.menu();
            //Mapa.imprimir(matrizFondo);

            Console.ReadKey();

        }
    }
}
