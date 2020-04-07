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
    public partial class score_option : UserControl
    {
        
        public score_option()
        {
            InitializeComponent();
            
        }
        private Jugador _jugador;
        public void insertarNombre(Jugador jugador)
        {
            _jugador = jugador;
            llenarTabla();
            this.label2.Text = "Score de " + _jugador.Nombre + " " + _jugador.Apepat + " " + _jugador.Apemat;
        }

        private void llenarTabla()
        {
            List<Estadistica> estadisticas = (new Conexion()).consultarEstadisticas(_jugador);
            dataGridView1.DataSource = estadisticas;
        }
    }
}
