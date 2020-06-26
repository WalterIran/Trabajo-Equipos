using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Equipos
{
    public class CLS_Validaciones
    {
        //Validacion para verificar que en el campo solo hayan letras
        public bool SoloLetras(ErrorProvider ubicacionError,TextBox[] txt, int cantidadTxt)
        {
            bool soloLetras = true;

            for(int i = 0; i<cantidadTxt; i++)
            {
                foreach(char caracter in txt[i].Text)
                {
                    if(!Char.IsLetter(caracter))
                    {
                        soloLetras = false;
                        ubicacionError.SetError(txt[i], "Ingrese letras en este campo");
                        break;
                    }
                    else
                    {
                        ubicacionError.SetError(txt[i], "");
                    }
                }
            }
            return soloLetras;
        }

        //Validacion para que solo se ingresen numeros y no acepte espacios en blancos
        public bool soloNumeros(ErrorProvider ubicacionError, TextBox[] txt, int cantidadTxt)
        {
            bool soloNumeros = true;

            for (int i = 0; i < cantidadTxt; i++)
            {
                foreach (char caracter in txt[i].Text)
                {
                    if(Char.IsWhiteSpace(caracter))
                    {
                        soloNumeros = false;
                        ubicacionError.SetError(txt[i], "No se permiten espacios");
                        break;
                    }
                    else if(!Char.IsNumber(caracter))
                    {
                        soloNumeros = false;
                        ubicacionError.SetError(txt[i], "Ingrese numeros en este campo");
                        break;
                    }
                    else
                    {
                        ubicacionError.SetError(txt[i], "");
                    }
                }
            }
            return soloNumeros;
        }

        //Validacion para que en los campos de texto no queden en blanco
        public bool FaltanDatos(ErrorProvider ubicacionError, TextBox[] texto, int tam)
        {
            bool faltan = false;
            for (int i = 0; i < tam; i++)
            {
                if (texto[i].Text == "")
                {
                    ubicacionError.SetError(texto[i], "Ingrese el dato correspondiente");
                    faltan = true;
                }
            }
            return faltan;
        }

    }
}
