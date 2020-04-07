using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUTDOOR.src.tools.objects
{
    public class EstadoPartida
    {
        public int Id_jugador { get; set; }
        public int PosicionObjetivoX { get; set; }
        public int PosicionObjetivoY { get; set; }
        public int PosicionJugadorX { get; set; }
        public int PosicionJugadorY { get; set; }
        public int VidaObjetivo { get; set; }
        public int VidaJugador { get; set; }
        public int Disparos { get; set; }
        public int Segundos { get; set; }
        public int Puntaje { get; set; }
        public int Interrumpida { get; set; }
    }
}
