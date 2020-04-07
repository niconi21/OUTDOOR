using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OUTDOOR.src.tools.database;
using OUTDOOR.src.tools.objects;
using OUTDOOR.src.tools;
using System.Threading;

namespace OUTDOOR.src.view.pages
{
    public partial class Login_page : Form
    {
        public Login_page()
        {
            InitializeComponent();
        }
        private void label5_Click(object sender, EventArgs e)
        {
            Registro_page registro = new Registro_page();
            registro.Show();
            this.Dispose();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String usuario = tb_usuario.Text;
                String clave = tb_clave.Text;
                Jugador jugador = (new Conexion()).login(usuario, clave);
                inicio_page inicio = new inicio_page(jugador);
                inicio.Show();
                this.Dispose();
            }
            catch (OUTDOOR_Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
