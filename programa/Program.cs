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
            Console.WriteLine("Pacman: \"{0}\"",  Console.Title);
            JugadorColeccion jugadores = new JugadorColeccion();
            //Se crea el mapa
            String[,] matrizFondo = Mapa.fondo();
            // se crea la copia de ma
            String[,] matrizComida = Mapa.comida(matrizFondo);
            // se crea la copia de ma
            String[,] matrizFantasma = Mapa.matrizFantasma(matrizComida);

            jugadores.llenar();            
            String opcion = "";

            Jugador player = new Jugador();
            int[] posicionPlayer = new int[2];
            bool play= true;
            bool vida = false;
            int comidaRestante = Mapa.contadorComida(matrizComida);

            Pantalla.start();
            while (play)
            {
                Pantalla.menu();
             //   opcion = Console.ReadLine();
                ConsoleKey opcionMenu = Console.ReadKey(true).Key;
                switch (opcionMenu)
                {
                    case ConsoleKey.D1:
                        opcion = "1";
                        break;
                    case ConsoleKey.D2:
                        opcion = "2";
                        break;
                    case ConsoleKey.D3:
                        opcion = "3";
                        break;
                    case ConsoleKey.D4:
                        opcion = "4";
                        break;

                }
                if (opcion.Equals("1"))
                {
                    //imprime salida para agregar
                    Pantalla.agregarJugador();
                    player.nombre = Console.ReadLine(); //pregunta nombre y lo agrega
                    player.puntaje = 0;
                    player.vida = 3;
                    player.contMovimiento = 0;                    
                    vida = jugadores.agregar(player); //incresa un nuevo jugador                   
                }
                if (opcion.Equals("2"))
                {
                    Pantalla.imprimirPuntajes(jugadores);
                }
                if (opcion.Equals("3"))
                {
                    vida = false;
                    play = false;
                }
                if (opcion.Equals("4"))
                {
                    Pantalla.exit();
                    vida = false;
                    play = false;
                }

                while (vida)
                {
                    Pantalla.imprimirFusion(matrizFondo,matrizComida);
                    // controles
                    Console.WriteLine("      Vida "+player.vida+"                      PUNTOS " + player.puntaje);
                    Console.WriteLine("C O N T R O L E S                MOVIMIENTOS " + player.contMovimiento); // "  comida restante " + comidaRestante 
                    Console.WriteLine("                         [W]");
                    Console.WriteLine("                     8.- ARRIBA");
                    Console.WriteLine("    4.- IZQUIERDA [A]             6.- DERECHA [D]");
                    Console.WriteLine("                     2.- ABAJO");
                    Console.WriteLine("                          [S]");
                    Console.WriteLine("");
                    // opcion = Console.ReadLine();
                    ConsoleKey tecla = Console.ReadKey(true).Key;
                    switch (tecla)
                    {
                        case ConsoleKey.W:
                            opcion = "w";
                            break;
                        case ConsoleKey.S:
                            opcion = "s";
                            break;
                        case ConsoleKey.A:
                            opcion = "a";
                            break;
                        case ConsoleKey.D:
                            opcion = "d";
                            break;

                    }
                    posicionPlayer = Mapa.buscarPlayer(matrizFondo); // se busca la posicion del jugador para tenerla guardada

                    if (!Mapa.movimientoPlayer(opcion, matrizFondo, posicionPlayer, player, matrizComida))
                    {
                        Console.WriteLine("No se puede hacer ese movimiento.");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else{
                        player.contMovimiento = player.contMovimiento + 1;
                        Mapa.movimientoFantasma(matrizFondo, player, matrizFantasma);
                    }                    
                }
            }                  
        }
    }
}
