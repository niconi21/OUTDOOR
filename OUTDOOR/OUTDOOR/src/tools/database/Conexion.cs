using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OUTDOOR.src.tools;
using OUTDOOR.src.tools.objects;

namespace OUTDOOR.src.tools.database
{
    public class Conexion
    {
        private SqlConnection conexion;

        public Conexion()
        {
            conexion = new SqlConnection("server=DESKTOP-OE9RG4S; database=OUTDOOR ; integrated security = true");
        }

        public Jugador login(String usuario, String clave)
        {
            conexion.Open();
            String consulta = "SELECT * FROM Jugador WHERE usuario = '" + usuario + "' AND clave = '" + clave + "'";
            SqlCommand sqlCommand = new SqlCommand(consulta, conexion);
            SqlDataReader dr = sqlCommand.ExecuteReader();
            if (dr.Read())
            {
                Jugador jugador = new Jugador
                {
                    id = int.Parse(dr["id_jugador"].ToString()),
                    Usuario = dr["usuario"].ToString(),
                    Clave = dr["clave"].ToString(),
                    Nombre = dr["nombre"].ToString(),
                    Apepat = dr["apepat"].ToString(),
                    Apemat = dr["apemat"].ToString()
                };
                dr.Close();
                conexion.Close();
                return jugador;
            }
            dr.Close();
            conexion.Close();
            throw new OUTDOOR_Exception("Usuario y/o contraseña incorrectos");
        }

        public void registro(Jugador jugador)
        {
            conexion.Open();
            String insertar = "INSERT INTO Jugador values ('" + jugador.Usuario + "','" + jugador.Clave + "','" + jugador.Nombre + "','" + jugador.Apepat + "','" + jugador.Apemat + "')";
            SqlCommand sqlCommand = new SqlCommand(insertar, conexion);
            sqlCommand.ExecuteNonQuery();
            conexion.Close();
        }

        public void insertarEstadistica(Estadistica estadistica)
        {
            conexion.Open();

            String insertar = "INSERT INTO Estadistica values (" + estadistica.id_jugador + "," + estadistica.Disparos + "," + estadistica.segundos + "," + estadistica.puntaje + "," + estadistica.vida + ")";
            SqlCommand sqlCommand = new SqlCommand(insertar, conexion);
            sqlCommand.ExecuteNonQuery();
            conexion.Close();
        }

        public void insertarEstadoPartida(EstadoPartida estadoPartida)
        {
            conexion.Open();
            String insertar = "INSERT INTO EstadoPartida values (" + estadoPartida.Id_jugador + "," + estadoPartida.PosicionObjetivoX + "," + estadoPartida.PosicionObjetivoY + "," + estadoPartida.PosicionJugadorX + "," + estadoPartida.PosicionJugadorY + "," + estadoPartida.VidaObjetivo + "," + estadoPartida.VidaJugador + "," + estadoPartida.Disparos + "," + estadoPartida.Segundos + "," + estadoPartida.Puntaje + "," + estadoPartida.Interrumpida + ")";
            SqlCommand sqlCommand = new SqlCommand(insertar, conexion);
            sqlCommand.ExecuteNonQuery();
            conexion.Close();
        }

        public EstadoPartida consultarEstadoPartida(Jugador jugador)
        {
            conexion.Open();
            String consulta = "SELECT * FROM EstadoPartida WHERE id_jugador = " + jugador.id + " AND interrumpida= 1";
            SqlCommand sqlCommand = new SqlCommand(consulta, conexion);
            SqlDataReader dr = sqlCommand.ExecuteReader();
            if (dr.Read())
            {
                EstadoPartida estadoPartida = new EstadoPartida
                {
                    Id_jugador = int.Parse(dr["id_jugador"].ToString()),
                    PosicionObjetivoX = int.Parse(dr["posicionObjetivoX"].ToString()),
                    PosicionObjetivoY = int.Parse(dr["posicionObjetivoY"].ToString()),
                    PosicionJugadorX = int.Parse(dr["posicionJugadorX"].ToString()),
                    PosicionJugadorY = int.Parse(dr["posicionJugadorY"].ToString()),
                    VidaObjetivo = int.Parse(dr["vidaObjetivo"].ToString()),
                    VidaJugador = int.Parse(dr["vidaJugador"].ToString()),
                    Disparos = int.Parse(dr["disparos"].ToString()),
                    Segundos = int.Parse(dr["segundos"].ToString()),
                    Puntaje = int.Parse(dr["puntaje"].ToString()),
                    Interrumpida = int.Parse(dr["interrumpida"].ToString())
                };
                dr.Close();
                conexion.Close();
                return estadoPartida;
            }
            dr.Close();
            conexion.Close();
            return null;
        }

        public void modificarEstadoPartida(Jugador jugador)
        {
            conexion.Open();
            String modificar = "UPDATE EstadoPartida SET interrumpida=0 WHERE id_jugador = " + jugador.id;
            SqlCommand sqlCommand = new SqlCommand(modificar, conexion);
            sqlCommand.ExecuteNonQuery();
            conexion.Close();
        }

        public List<Estadistica> consultarEstadisticas(Jugador jugador)
        {
            conexion.Open();
            String consulta = "SELECT * FROM Estadistica WHERE id_jugador = " + jugador.id + " ORDER BY disparos";
            SqlCommand sqlCommand = new SqlCommand(consulta, conexion);
            SqlDataReader dr = sqlCommand.ExecuteReader();
            List<Estadistica> estadisticas = new List<Estadistica>();
            while (dr.Read())
            {
                Estadistica estadistica = new Estadistica
                {
                    Disparos = int.Parse(dr["disparos"].ToString()),
                    segundos = int.Parse(dr["segundos"].ToString()),
                    puntaje = int.Parse(dr["puntaje"].ToString()),
                    vida = int.Parse(dr["vida"].ToString()),
                };
                estadisticas.Add(estadistica);
            }
            return estadisticas;
        }
    }
}
