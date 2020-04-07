using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OUTDOOR.src.tools.objects;
using OUTDOOR.src.tools.database;
using OUTDOOR.src.tools;
using System.Threading;

namespace OUTDOOR.src.view.pages
{
    public partial class Registro_page : Form
    {
        public Registro_page()
        {
            InitializeComponent();
        }

       
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Login_page login = new Login_page();
            login.Show();
            this.Dispose();
        }

        private void btn_registro_Click(object sender, EventArgs e)
        {
            try
            {
               Jugador jugador = new Jugador
                {
                    Usuario = tb_usuario.Text,
                    Clave = tb_clave.Text,
                    Nombre = tb_nombre.Text,
                    Apepat = tb_apepat.Text,
                    Apemat = tb_apemat.Text
                };
                (new Conexion()).registro(jugador);
                (new Login_page()).Show();
                this.Dispose();

            }
            catch (OUTDOOR_Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
    }
}
