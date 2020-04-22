using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OUTDOOR.src.view.components
{
    public partial class componet_jugador : UserControl
    {
        private delegate void del();
        private int _vidaQuitada = 5;
        public componet_jugador()
        {
            InitializeComponent();
            Vida = 100;
        }

        public void insetarNivel(int nivel)
        {
            this._vidaQuitada = nivel * 5;
        }

        public int Vida { get; set; }

        public void recuperarVida()
        {
            progressBar1.Value = Vida;
        }

        public void restarVida()
        {
            if (InvokeRequired)
            {
                del restar = new del(restarVida);
                Invoke(restar);
            }
            else
            {
                try
                {
                    if (progressBar1.Value >= 1)
                    {

                        progressBar1.Value -= _vidaQuitada;
                    }
                    Vida = progressBar1.Value;
                }
                catch {
                    progressBar1.Value = 0;
                    Vida = 0;
                }
            }
        }
        public void aumentarVida()
        {
            if (InvokeRequired)
            {
                del aumentar = new del(aumentarVida);
                Invoke(aumentar);
            }
            else
            {
                try
                {
                    if (progressBar1.Value < 100)
                    {

                        progressBar1.Value += 5;
                    }
                    Vida = progressBar1.Value;
                }
                catch { }
            }
        }
    }
}
