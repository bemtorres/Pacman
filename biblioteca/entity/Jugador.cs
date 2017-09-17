using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace biblioteca
{
    public class Jugador
    {
        public String nombre { get; set; }
        public int puntaje { get; set; }
        public int vida { get; set; }

        public Jugador(String nombre, int puntaje) {
            this.nombre = nombre;
            this.puntaje = puntaje;          
        }


        public Jugador() {
            Init();
        }

        private void Init() {
            nombre = String.Empty;
            puntaje = 0;
            vida = 0;
        }

        public override string ToString()
        {
            return "Nombre jugador: "+nombre+"  score: "+ puntaje;
        }
    }
}
