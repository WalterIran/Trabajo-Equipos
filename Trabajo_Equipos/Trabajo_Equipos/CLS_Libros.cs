using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Equipos
{
    public class CLS_Libros
    {
        //Arreglo de los tipos de libro
        private string[] tipoLibro = new string[] { "Libro de texto", "Novela", "Cuento" };
       //Demás atributos
        private string nombreLibro;
        private double precioBase;
        private double precioAdicional;
        private double subtotal;

        //Constructor
        public CLS_Libros()
        {
            this.precioBase = 0;
            this.precioAdicional = 0;
        }

        //Metodos setter y getter de tres atributos
        public string NombreLibro { get => nombreLibro; set => nombreLibro = value; }
        public double PrecioBase { get => precioBase; set => precioBase = value; }
        public double PrecioAdicional { get => precioAdicional; set => precioAdicional = value; }

        //Clase para calculo de subtotal
        public double CalculoSubtotal()
        {
            subtotal = precioAdicional + precioBase;
            return subtotal;
        }

        //Clase para devolución de tipo de libro
        public string TipoLibro(int opc)
        {
            switch (opc)
            {
                case 1:
                    return tipoLibro[opc];

                case 2:
                    return tipoLibro[opc];

                default:
                    return tipoLibro[opc];
            }
        }
    }
}
