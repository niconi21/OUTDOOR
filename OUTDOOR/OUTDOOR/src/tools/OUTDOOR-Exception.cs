using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OUTDOOR.src.tools
{
    public class OUTDOOR_Exception : Exception
    {
        private String _error;
        public OUTDOOR_Exception(String error)
        {
            this._error = error;
        }
        public override string ToString()
        {
            return "Error: " + _error;
        }
    }
}
