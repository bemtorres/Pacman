using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using biblioteca.entity;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            String[,] matrizFondo = Mapa.fondo();
            // se crea la copia de ma
            String[,] matrizComida = Mapa.comida(matrizFondo);
            Pantalla.imprimir(matrizComida);
            Console.ReadKey();
        }
    }
}
