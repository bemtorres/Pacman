using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using biblioteca.entity;

namespace programa
{
    class Program
    {
        static void Main(string[] args)
        {
            String[,] matrizFondo = Mapa.fondo();
            String[,] matrizComida = Mapa.comida(matrizFondo);

            Mapa.imprimir(matrizFondo);

            Console.ReadKey();

        }
    }
}
