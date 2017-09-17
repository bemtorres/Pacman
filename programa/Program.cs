using System;
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

            jugadores.llenar();
            String[,] matrizFondo = Mapa.fondo();
            String[,] matrizComida = Mapa.comida(matrizFondo);
            String opcion = "";

            Jugador player = new Jugador();
            bool play= true;
            bool vida = false;

            Mapa.start();
            while (play)
            {
                Mapa.menu();
                opcion = Console.ReadLine();
                if (opcion.Equals("1"))
                {
                    Mapa.agregarJugador();
                    player.nombre = Console.ReadLine();
                    player.puntaje = 0;
                    player.vida = 3;
                    player.contMovimiento = 0;
                    vida = jugadores.agregar(player); ;
                }
                if (opcion.Equals("2"))
                {
                    Mapa.imprimirPuntajes(jugadores);
                }

                while (vida)
                {
                    //
                    //
                    //CADENA DE MANDO
                    //
                    //
                    Console.WriteLine("< < < <                          PUNTOS " + player.puntaje);
                    Console.WriteLine("C O N T R O L E S                MOVIMIENTOS " + player.contMovimiento);
                    Console.WriteLine("                         [W]");
                    Console.WriteLine("                     8.- ARRIBA");
                    Console.WriteLine("    4.- IZQUIERDA [A]             6.- DERECHA [D]");
                    Console.WriteLine("                     2.- ABAJO");
                    Console.WriteLine("                          [S]");
                    Console.WriteLine("");
                    // do
                    //{
                    opcion = Console.ReadLine();
                }
            }
           





            Mapa.menu();
            //Mapa.imprimir(matrizFondo);

            Console.ReadKey();

        }
    }
}
