using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OUTDOOR.src.tools.objects;
using OUTDOOR.src.tools.database;

namespace OUTDOOR.src.view.pages
{
    public partial class Juego_page : Form
    {
        private Jugador _jugador;
        private EstadoPartida _estadoPartida;

        private int _iniciar = 0;
        private int _vidaObjetivo = 100;
        private int _vidaJugador = 100;
        private int _disparos = 0;
        private int _segundos = 0;
        private int _puntaje = 0;

        private Thread _balaJugador;
        private Thread _balaObjetivo;
        private Thread _objetivo;
        private Thread _tiempo;

        private delegate void del(Control c, int x, int y);

        public Juego_page(Jugador jugador)
        {
            InitializeComponent();
            _jugador = jugador;
            if (exitePartidaInterrumpida())
            {
                inicio.Location = new Point(20,inicio.Location.Y);
                inicio.Text = "¿Deseas continuar con la partida anterior? (Y/N)";
            }

        }
        private void moverControl(Control c, int x, int y)  
        {
            if (InvokeRequired)
            {
                try
                {
                    del mover = new del(moverControl);
                    Object[] parametros = new Object[] { c, x, y };
                    Invoke(mover, parametros);
                }
                catch
                {
                }
            }
            else
            {
                c.Location = new Point(x, y);
            }
        }
        private void borrarControl(Control c, int x, int y)
        {
            if (InvokeRequired)
            {
                del borrar = new del(borrarControl);
                Object[] parametros = new Object[] { c, x, y };
                Invoke(borrar, parametros);
            }
            else
            {
                c.Dispose();
                _vidaJugador = pb_jugador.Vida;
                _vidaObjetivo = pb_objetivo.Vida;
                
                if (finJuego())
                {
                    inicio.Text = ganador();
                    inicio.Visible = true;
                    pararJuego();
                    fin.Visible = true;
                    _iniciar = 2;
                }
            }
        }
        private void crearControl(Control c, int x, int y)
        {
            if (InvokeRequired)
            {
                del crear = new del(crearControl);
                Object[] parametros = new Object[] { c, x, y };
                Invoke(crear, parametros);
            }
            else
            {
                this.Controls.Add(c);
            }
        }
        private void modificarTiempo(Control c, int x, int y)
        {
            if (InvokeRequired)
            {
                del tiempo = new del(modificarTiempo);
                Object[] parametros = new Object[] { c, x, y };
                Invoke(tiempo, parametros);
            }
            else
            {
                this.tiempo.Text = "Tiempo: " + x + " segundos";
            }
        }
        private void Juego_page_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 'Y' || e.KeyChar == 'y') && _iniciar == 4)//para continuar partida suspendida
            {
                _iniciar = 1;
                pb_jugador.Location = new Point(_estadoPartida.PosicionJugadorX, _estadoPartida.PosicionJugadorY);
                pb_objetivo.Location = new Point(_estadoPartida.PosicionObjetivoX, _estadoPartida.PosicionObjetivoY);
                pb_jugador.Vida = _estadoPartida.VidaJugador;
                pb_objetivo.Vida = _estadoPartida.VidaObjetivo;
                pb_objetivo.recuperarVida();
                pb_jugador.recuperarVida();
                _vidaJugador = _estadoPartida.VidaJugador;
                _vidaObjetivo = _estadoPartida.VidaObjetivo;
                _disparos = _estadoPartida.Disparos;
                _segundos = _estadoPartida.Segundos;
                _puntaje = _estadoPartida.Puntaje;
                (new Conexion()).modificarEstadoPartida(_jugador);
                this.inicio.Visible = false;
                this.pb_jugador.Visible = true;
                this.pb_objetivo.Visible = true;
                _objetivo = new Thread(mover_objetivo);
                _objetivo.Start();
                _tiempo = new Thread(medirTiempo);
                _tiempo.Start();
            }
            if ((e.KeyChar == 'N' || e.KeyChar == 'n') && _iniciar == 4)//para continuar partida suspendida
            {
                _iniciar = 1;
                (new Conexion()).modificarEstadoPartida(_jugador);
                this.inicio.Visible = false;
                this.pb_jugador.Visible = true;
                this.pb_objetivo.Visible = true;
                _objetivo = new Thread(mover_objetivo);
                _objetivo.Start();
                _tiempo = new Thread(medirTiempo);
                _tiempo.Start();
            }

            if (e.KeyChar == 13 && _iniciar == 0)//para iniciar o continuar partida
            {
                _iniciar++;
                this.inicio.Visible = false;
                this.pb_jugador.Visible = true;
                this.pb_objetivo.Visible = true;
                _objetivo = new Thread(mover_objetivo);
                _objetivo.Start();
                _tiempo = new Thread(medirTiempo);
                _tiempo.Start();
                
            }
            if (e.KeyChar == 13 && _iniciar == 2)//para guardar y salir de partida terminada
            {
                guardarDatos();
                (new inicio_page(_jugador)).Show();
                this.Dispose();
            }

            if (e.KeyChar == 27)//para salir de la partida
            {
                partidaInterrumpida();
                pararJuego();
                (new inicio_page(_jugador)).Show();
                this.Dispose();
            }

            if (e.KeyChar == 'p' && _iniciar == 1)//para poner pausa
            {
                _iniciar--;
                this.inicio.Visible = true;
                this.inicio.Text = "Presiona enter para continuar";
                this.pb_jugador.Visible = false;
                this.pb_objetivo.Visible = false;
                _objetivo.Abort();
            }

            if (e.KeyChar == 'a' || e.KeyChar == 'A')//mover a la izquierda el jugador
            {
                if (pb_jugador.Location.X > 0)
                    pb_jugador.Location = new Point(pb_jugador.Location.X - 10, pb_jugador.Location.Y);
            }
            if (e.KeyChar == 'd' || e.KeyChar == 'D')//mover a la derecha el jugador
            {
                if (pb_jugador.Location.X < this.Width - 250)
                    pb_jugador.Location = new Point(pb_jugador.Location.X + 10, pb_jugador.Location.Y);
            }
            if (e.KeyChar == ' ')//balas del jugador
            {
                PictureBox bala = new PictureBox();
                bala.BackColor = Color.Red;
                bala.Size = new Size(8, 15);
                bala.Location = new Point(this.pb_jugador.Location.X + (this.pb_jugador.Width / 2), this.pb_jugador.Location.Y - 10);
                this.Controls.Add(bala);
                _disparos++;
                _balaJugador = new Thread(mover_balaJugador);
                _balaJugador.Start(bala);
            }

        }
        private void mover_balaJugador(Object sender)
        {
            PictureBox bala=sender as PictureBox;
            int x = bala.Location.X;
            int y = bala.Location.Y;
            while (bala.Location.Y > 0)
            {
                Thread.Sleep(10);
                moverControl(bala, x, y -= 5);
                if (pb_objetivo.Bounds.Contains(bala.Location))
                {
                    _puntaje++;
                    pb_jugador.aumentarVida();
                    pb_objetivo.restarVida();
                    break;
                }
            }
            borrarControl(bala, x, y);
        }
        private void mover_objetivo()
        {
            Point ubicacion = pb_objetivo.Location;
            while (true)
            {
                while (true)
                {
                    Thread.Sleep(10);
                    _balaObjetivo = new Thread(mover_balaObjetivo);
                    _balaObjetivo.Start();
                    moverControl(pb_objetivo, ubicacion.X+=5, ubicacion.Y);
                    if (ubicacion.X > this.Width - 250)
                        break;
                }
                while (true)
                {
                    Thread.Sleep(10);
                    _balaObjetivo = new Thread(mover_balaObjetivo);
                    _balaObjetivo.Start();
                    moverControl(pb_objetivo, ubicacion.X -= 5, ubicacion.Y);
                    if (ubicacion.X < 0)
                        break;
                }
            }
        }
        private void mover_balaObjetivo()
        {
            int aleatorio = (new Random()).Next(0, 25);
            if (aleatorio == 1)
            {
                PictureBox bala = new PictureBox();
                bala.BackColor = Color.Blue;
                bala.Size = new Size(8,15);
                bala.Location = new Point(pb_objetivo.Location.X + (pb_objetivo.Width / 2),pb_objetivo.Location.Y);
                crearControl(bala, bala.Location.X, bala.Location.Y + bala.Height);
                
                int x = bala.Location.X;
                int y = bala.Location.Y;
                while (bala.Location.Y < this.Height - 10)
                {
                    Thread.Sleep(10);
                    moverControl(bala, x, y += 5);
                    if (pb_jugador.Bounds.Contains(bala.Location))
                    {
                        pb_jugador.restarVida();
                        pb_objetivo.aumentarVida();
                        break;
                    }
                        
                }
                borrarControl(bala, x, y);
            }
        }
        private bool finJuego()
        {
            if (_vidaObjetivo == 0 || _vidaJugador == 0)
                return true;
            return false;
        }
        private String ganador()
        {
            if (_vidaObjetivo <= 5)
                return "Felicidades, has ganado";
            if (_vidaJugador <= 5)
                return "Has pedido!";
            return "Ha fallado el juego";
        }
        private void pararJuego()
        {
            _tiempo.Abort();
            _objetivo.Abort();
            try
            {
                _balaJugador.Abort();
            }
            catch { }
            try
            {
                _balaObjetivo.Abort();
            }
            catch { }
            
            
        }
        private void medirTiempo()
        {
            while (true)
            {
                Thread.Sleep(1000);
                _segundos++;
                modificarTiempo(null, _segundos, 0);

            }
        }
        private void guardarDatos()
        {
            Estadistica estadistica = new Estadistica
            {
                id_jugador = _jugador.id,
                Disparos = _disparos,
                puntaje = _puntaje,
                segundos = _segundos,
                vida = _vidaJugador
            };
            (new Conexion()).insertarEstadistica(estadistica);
        }
        private void partidaInterrumpida()
        {
            int interrumpida = 0;
            if (_vidaJugador > 0 || _vidaObjetivo > 0)
                interrumpida = 1;
            EstadoPartida estadoPartida = new EstadoPartida
            {
                Id_jugador = _jugador.id,
                PosicionJugadorX = pb_jugador.Location.X,
                PosicionJugadorY = pb_jugador.Location.Y,
                PosicionObjetivoX = pb_objetivo.Location.X,
                PosicionObjetivoY = pb_objetivo.Location.Y,
                VidaObjetivo = _vidaObjetivo,
                VidaJugador = _vidaJugador,
                Disparos = _disparos,
                Segundos = _segundos,
                Puntaje = _puntaje,
                Interrumpida = interrumpida
            };
            (new Conexion()).insertarEstadoPartida(estadoPartida);
        }
        private bool exitePartidaInterrumpida()
        {
            _estadoPartida = (new Conexion()).consultarEstadoPartida(_jugador);
            if (_estadoPartida != null)
            {
                _iniciar = 4;
                return true;
            }
            return false;
        }
        
    }
}