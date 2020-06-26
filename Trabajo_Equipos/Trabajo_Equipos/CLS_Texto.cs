using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Equipos
{
    public class CLS_Texto : CLS_Libros
    {
        private string[] materiaTexto = new string[]   {"Matemáticas","Computación" };
        private string autor;
        private string editorial;
        private int edicion;

        public CLS_Texto()
        {
            this.Autor = " ";
            this.Editorial = " ";
            this.Edicion = 0;
        }

        public string Autor { get => autor; set => autor = value; }
        public string Editorial { get => editorial; set => editorial = value; }
        public int Edicion { get => edicion; set => edicion = value; }
        public string getMateriaTexto(int n) {
            switch (n)
            {
                case 0:
                    return materiaTexto[n];
                default:
                    return materiaTexto[n];
            }
        
        }
    }
}
