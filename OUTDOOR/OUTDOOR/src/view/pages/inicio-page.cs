using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OUTDOOR.src.view.options;
using OUTDOOR.src.tools.objects;

namespace OUTDOOR.src.view.pages
{
    public partial class inicio_page : Form
    {
        private Inicio_option inicio;
        private Jugador _jugador;
        public inicio_page(Jugador jugador)
        {
            _jugador = jugador;
            InitializeComponent();
            inicio = new Inicio_option();
            inicio.insertarNombre(_jugador);
            inicio.Dock = DockStyle.Fill;
            this.panel_contenedor.Controls.Add(inicio);
        }

        void Animacion_menu_entrar(object sender, EventArgs e)
        {
            Control panel = sender as Control;
            panel.BackColor = Color.FromArgb(129, 40, 52);
        }
        void Animacion_menu_salir(object sender, EventArgs e)
        {
            Control panel = sender as Control;
            if (!panel.Bounds.Contains(this.PointToClient(Cursor.Position)))
            {
                panel.BackColor = Color.FromArgb(86, 7, 35);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            inicio.pararHilo();
            Login_page login = new Login_page();
            login.Show();
            this.Dispose();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            this.panel_contenedor.Controls.Clear();
            inicio.pararHilo();
            inicio = new Inicio_option();
            inicio.Dock = DockStyle.Fill;
            inicio.insertarNombre(_jugador);
            this.panel_contenedor.Controls.Add(inicio);

        }

        private void panel9_Click(object sender, EventArgs e)
        {
            inicio.pararHilo();
            this.panel_contenedor.Controls.Clear();
            score_option score = new score_option();
            score.Dock = DockStyle.Fill;
            score.insertarNombre(_jugador);
            this.panel_contenedor.Controls.Add(score);
        }

        private void panel11_Click(object sender, EventArgs e)
        {
            inicio.pararHilo();
            this.panel_contenedor.Controls.Clear();
            Estadisticas_option estadisticas = new Estadisticas_option();
            estadisticas.Dock = DockStyle.Fill;
            estadisticas.insertarNombre(_jugador);
            this.panel_contenedor.Controls.Add(estadisticas);
        }

        private void panel13_Click(object sender, EventArgs e)
        {
            inicio.pararHilo();
            this.panel_contenedor.Controls.Clear();
            Creditos_option creditos = new Creditos_option();
            creditos.Dock = DockStyle.Fill;
            
            this.panel_contenedor.Controls.Add(creditos);
        }

        private void inicio_page_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                inicio.pararHilo();
                (new Juego_page(_jugador)).Show();
                this.Dispose();
            }
        }
    }
}
