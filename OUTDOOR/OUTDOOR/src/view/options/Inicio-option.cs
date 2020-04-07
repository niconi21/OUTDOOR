using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using OUTDOOR.src.tools.objects;
namespace OUTDOOR.src.view.options
{
    public partial class Inicio_option : UserControl
    {
        Thread hilo;
        public Inicio_option()
        {
            InitializeComponent();
            hilo = new Thread(parpadeo);
            hilo.Start();
        }

        private Jugador _jugador;
        public void insertarNombre(Jugador jugador)
        {
            _jugador = jugador;
            this.label2.Text = "Score de " + _jugador.Nombre + " " + _jugador.Apepat + " " + _jugador.Apemat;
        }
    

        private void parpadeo()
        {
            while (true)
            {
                Thread.Sleep(1000);
                par();
            }
        }

        private void par()
        {
            if (InvokeRequired)
            {
                del_parpadeo dp = new del_parpadeo(par);
                Invoke(dp);
            }
            else
            {
                if (label1.Visible)
                {
                    label1.Visible = false;
                }
                else
                {
                    label1.Visible = true;
                }
            }
        }

        private delegate void del_parpadeo();


        public void pararHilo()
        {
            this.hilo.Abort();
        }

    }
}
