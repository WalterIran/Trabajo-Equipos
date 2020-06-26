using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Equipos
{
    public class CLS_Clientes
    {
        private string nombre;
        private string numTelefono;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public string NumTelefono { get => numTelefono; set => numTelefono = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
