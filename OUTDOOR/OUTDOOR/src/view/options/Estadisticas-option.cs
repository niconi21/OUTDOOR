using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OUTDOOR.src.tools.objects;
using OUTDOOR.src.tools.database;

namespace OUTDOOR.src.view.options
{
    public partial class Estadisticas_option : UserControl
    {
        private int _disparos = 0;
        private int _puntaje = 0;
        private int _segundos = 0;
        private Estadistica _mejorJuego;
        private Jugador _jugador;
        public Estadisticas_option()
        {
            InitializeComponent();
        }
        
        public void insertarNombre(Jugador jugador)
        {
            _jugador = jugador;
            this.label2.Text = "Score de " + jugador.Nombre + " " + jugador.Apepat + " " + jugador.Apemat;
            obtenerEstadistica();
            mostrarGrafica();
            mostrarInformacion();
        }

        private void obtenerEstadistica()
        {
            List<Estadistica> estadisticas = (new Conexion()).consultarEstadisticas(_jugador);
            if (estadisticas != null)
            {
                _mejorJuego = estadisticas.ElementAt(0);
                foreach (var item in estadisticas)
                {
                    _puntaje += item.puntaje;
                    _disparos += item.Disparos;
                    _segundos += item.segundos;
                }
            }
        }

        private void mostrarGrafica()
        {
            chart1.Series[0].Points.AddXY(0, _disparos);
            chart1.Series[1].Points.AddXY(0, _segundos);
            chart1.Series[2].Points.AddXY(0, _puntaje);
        }
        private void mostrarInformacion()
        {
            lbl_diparos.Text = "Disparos: " + _disparos + " disparos realizados";
            lbl_segundos.Text = "Segundos: " + _segundos + " segundos jugados";
            lbl_puntos.Text = "Puntaje: " + _puntaje+ " puntos ganados";
            lbl_mejorPartida.Text = "La mejor partita tiene " + _mejorJuego.Disparos + " disparos\ncon " + _mejorJuego.segundos + " segundos jugados y con " + _mejorJuego.puntaje + " puntos ganados";
        }
    }
}
