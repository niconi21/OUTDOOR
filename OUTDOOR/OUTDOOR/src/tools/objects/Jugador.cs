using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OUTDOOR.src.tools;

namespace OUTDOOR.src.tools.objects
{
    public class Jugador
    {
        
        private String _usuario;
        private String _clave;
        private String _nombre;
        private String _apepat;
        private String _apemat;

        public int id { get; set; }
        public String Usuario
        {
            get
            {
                return _usuario;
            }
            set
            {
                if (!value.Equals(""))
                {
                    this._usuario = value; ;
                }
                else
                {
                    throw new OUTDOOR_Exception("Ingrese un nombre de usuario valido");
                }
            }
        }
        public String Clave
        {
            get
            {
                return _clave;
            }
            set
            {
                if (!value.Equals(""))
                {
                    this._clave = value; ;
                }
                else
                {
                    throw new OUTDOOR_Exception("Ingrese una clave de usuario valido");
                }
            }
        }
        public String Nombre
        {
            get
            {
                return _nombre;
            }
            set
            {
                if (!value.Equals(""))
                {
                    this._nombre = value; ;
                }
                else
                {
                    throw new OUTDOOR_Exception("Ingrese un nombre valido");
                }
            }
        }
        public String Apepat
        {
            get
            {
                return _apepat;
            }
            set
            {
                if (!value.Equals(""))
                {
                    this._apepat = value; ;
                }
                else
                {
                    throw new OUTDOOR_Exception("Ingrese un apellido paterno valido");
                }
            }
        }
        public String Apemat
        {
            get
            {
                return _apemat;
            }
            set
            {
                if (!value.Equals(""))
                {
                    this._apemat = value; ;
                }
                else
                {
                    throw new OUTDOOR_Exception("Ingrese un apellido materno valido");
                }
            }
        }
    }
}
