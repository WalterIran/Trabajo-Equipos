using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Equipos
{
    public partial class FRM_Principal : Form
    {
        bool cambioEdad;
        public FRM_Principal()
        {
            InitializeComponent();
            dateTimePicker_Nacimiento.MaxDate = DateTime.Now.AddYears(-18);
        }

        CLS_Clientes cliente = new CLS_Clientes();
        CLS_Validaciones validacion = new CLS_Validaciones();
        const int cantTxtNumeros = 1;
        const int cantTxtLetras = 1;

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            TextBox[] textos = new TextBox[] { txt_NombreCliente, txt_NumTelefono };
            TextBox[] textoLetras = new TextBox[] { txt_NombreCliente};
            TextBox[] textoNumeros = new TextBox[] { txt_NumTelefono };

            DialogResult resultado = DialogResult.No;

            if (!NoVacios(textos) && validacion.SoloLetras(errorProvider, textoLetras, cantTxtLetras) 
                && validacion.soloNumeros(errorProvider, textoNumeros, cantTxtNumeros))
            {
                if (!cambioEdad)
                {
                    resultado = MessageBox.Show("¿Ingresaste tu edad?", "Advertencia",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                    if (resultado == DialogResult.Yes)
                    {
                        SiguienteForm();
                    }
                }
                else
                {
                    SiguienteForm();
                }
            }
        }

        //Validar que los campos no esten vacios
        private bool NoVacios(TextBox [] txt)
        {
            bool textosCompletos = false;

            if (validacion.FaltanDatos(errorProvider, txt, cantTxtLetras + cantTxtNumeros))
            {
                textosCompletos = true;
            }
            else
            {
                for(int i = 0; i<cantTxtLetras+cantTxtNumeros; i++)
                {
                    errorProvider.SetError(txt[i], "");
                }
            }

            return textosCompletos;
        }

        //Pasar al siguiente form
        private void SiguienteForm()
        {
            cambioEdad = false;

            cliente.Nombre = txt_NombreCliente.Text;
            cliente.NumTelefono = txt_NumTelefono.Text;
            cliente.Edad = dateTimePicker_Nacimiento.Value.Year - DateTime.Today.Year;

            FRM_Nucleo nucleo = new FRM_Nucleo();
            this.Hide();
            nucleo.ShowDialog();
        }

        private void dateTimePicker_Nacimiento_ValueChanged(object sender, EventArgs e)
        {
            cambioEdad = true;
        }

        private void FRM_Principal_Load(object sender, EventArgs e)
        {
            cambioEdad = false;
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_NombreCliente.Clear();
            txt_NumTelefono.Clear();
            cambioEdad = false;
        }
    }
}
