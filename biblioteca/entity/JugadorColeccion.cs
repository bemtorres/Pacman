using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace biblioteca.entity
{
    public class JugadorColeccion
    {
        private List<Jugador> jugadores = new List<Jugador>();

        public JugadorColeccion() {
            jugadores = new List<Jugador>();
        }

        public Boolean agregar(Jugador jugador) {
            if (jugador != null)
            {
                jugadores.Add(jugador);
                return true;
            }
            return false;
        }

        public List<Jugador> listar() {
            return jugadores;
        }

        public void llenar() {
            agregar(new Jugador("aaa",200));
            agregar(new Jugador("ccc",400));
            agregar(new Jugador("OOO",500));
            agregar(new Jugador("Maestro",1000));
            agregar(new Jugador("mrbm",2000));
            agregar(new Jugador("win",1));
        }
    }
}
