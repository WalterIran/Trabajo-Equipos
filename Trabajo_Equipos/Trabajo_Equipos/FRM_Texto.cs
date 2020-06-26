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
    public partial class FRM_Texto : Form
    {
        CLS_Texto texto = new CLS_Texto();
        CLS_Validaciones validacion = new CLS_Validaciones();
        const int cantTxtLetras = 3;

        public FRM_Texto()
        {
            InitializeComponent();
        }

        //Boton Cancelar
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Boton Aceptar
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            TextBox[] textoLetras = new TextBox[] { txt_Autor, txt_Editorial, txt_TituloLibro };

            if (validacion.SoloLetras(errorProvider, textoLetras, cantTxtLetras))
            {
                MessageBox.Show("Listo");
                texto.NombreLibro = txt_TituloLibro.Text;
                texto.Autor = txt_Autor.Text;
                texto.Editorial = txt_Editorial.Text;
                texto.Edicion = int.Parse(nup_Edicion.Value.ToString());
                this.Close();
            }
        }

        //----- error de dedo ------
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        //----- error de dedo ------
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        //Sleccion de materia y calculo de datos
        private void cb_Categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cb_Categoria.SelectedIndex;
            if (indice != -1)
            {
                switch (indice)
                {
                    case 0:
                        txt_PrecioAdicion.Text = "0.00";
                        break;
                    default:
                        txt_PrecioAdicion.Text = "100.00";
                        break;
                }
            }

            txt_PrecioBase.Text = "300.00";
            texto.PrecioBase = Math.Round(double.Parse(txt_PrecioBase.Text), 2);
            texto.PrecioAdicional = Math.Round(double.Parse(txt_PrecioAdicion.Text), 2);
            txt_SubtotalTexto.Text = $"{texto.CalculoSubtotal()}";

            btn_Aceptar.Visible = true;
            lbl_PrecioAdicional.Visible = true;
            txt_PrecioAdicion.Visible = true;
            lbl_PrecioBase.Visible = true;
            txt_PrecioBase.Visible = true;
            lbl_Subtotal.Visible = true;
            txt_SubtotalTexto.Visible = true;
            
        }

        //Carga de datos al formulario
        private void FRM_Texto_Load(object sender, EventArgs e)
        {
            for (int i=0; i<2; i++)
            {
                cb_Categoria.Items.Add(texto.getMateriaTexto(i));
            }

            cb_Categoria.Text = " ";
            btn_Aceptar.Visible = false;
            lbl_PrecioAdicional.Visible = false;
            txt_PrecioAdicion.Visible = false;
            lbl_PrecioBase.Visible = false;
            txt_PrecioBase.Visible = false;
            lbl_Subtotal.Visible = false;
            txt_SubtotalTexto.Visible = false;
            txt_TituloLibro.Text = " ";
            txt_Autor.Text = " ";
            txt_Editorial.Text = " ";
            nup_Edicion.Value = 1;
        }

        //Boton Limpiar
        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            cb_Categoria.SelectedIndex = -1;
            btn_Aceptar.Visible = false;
            lbl_PrecioAdicional.Visible = false;
            txt_PrecioAdicion.Visible = false;
            lbl_PrecioBase.Visible = false;
            txt_PrecioBase.Visible = false;
            lbl_Subtotal.Visible = false;
            txt_SubtotalTexto.Visible = false;
            txt_TituloLibro.Text = " ";
            txt_Autor.Text = " ";
            txt_Editorial.Text = " ";
            nup_Edicion.Value = 1;
        }
    }
}
