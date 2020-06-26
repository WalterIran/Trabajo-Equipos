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
    public partial class FRM_Nucleo : Form
    {
        public FRM_Nucleo()
        {
            InitializeComponent();
            lista_Tipo.Items.Add("novela");
            lista_NombreLibro.Items.Add("harry p");
            lista_Precio.Items.Add("123");

            lista_Tipo.Items.Add("cuento");
            lista_NombreLibro.Items.Add("caperu");
            lista_Precio.Items.Add("50");
        }

        //Variable global
        double subtotal = 0;

        //Al hacer click en el boton Elegir
        private void btnEleccion_Click(object sender, EventArgs e)
        {
            int indice = cb_TipoLibro.SelectedIndex;

            if(indice != -1)
            {
                switch (indice)
                {
                    case 0:
                        break;

                    case 1:
                        break;

                    case 2:
                        break;
                }
                Visibles(1);
            }
            else
            {
                errorProvider.SetError(cb_TipoLibro, "Elige un tipo de libro");
            }
            
        }

        //Metodo para adicionar el libro especificado
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            subtotal = 0;

            for(int i= 0; i<lista_Precio.Items.Count; i++) 
            { 
                subtotal += double.Parse(lista_Precio.Items[i].ToString()); 
            }

            txt_subtotal.Text = $"L.{Math.Round(subtotal, 2)}";
            
            Invisibles(1);
            Visibles(2);
        }

        //Metodo para adicionar otro libro a la lista
        private void btnOtroLibro_Click(object sender, EventArgs e)
        {
            Invisibles(2);
            btnEleccion.Visible = true;
            errorProvider.SetError(btn_BorrarSelec, "");
        }

        //Metodo para finalizar compra
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (subtotal == 0)
            {
                errorProvider.SetError(btnFinalizar, "Su compra está vacía");
            }
            else
            {
                if (!rb_Efectivo.Checked && !rb_tarjeta.Checked)
                {
                    errorProvider.SetError(gb_metodoPago, "Elige un método de pago");
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("¿Desea finalizar la compra?", "Finalizar compra",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (resultado == DialogResult.Yes)
                    {
                        Invisibles(1);
                        Invisibles(2);
                    }
                }
            }
        }

        //metodo para volver visibles los elementos
        public void Visibles(int lado)
        {
            switch (lado)
            {
                case 1:
                    btnAdicionar.Visible = true;
                    btnBorrar.Visible = true;
                    txt_DescGeneral.Visible = true;
                    btnEleccion.Visible = true;
                    break;

                case 2:
                    btn_BorrarSelec.Visible = true;
                    btnOtroLibro.Visible = true;
                    gb_metodoPago.Visible = true;
                    btnFinalizar.Visible = true;
                    break;
            }

        }

        //metodo para volver invisibles los elementos
        public void Invisibles(int lado)
        {
            switch (lado)
            {
                case 1:
                    btnAdicionar.Visible = false;
                    btnBorrar.Visible = false;
                    txt_DescGeneral.Visible = false;
                    btnEleccion.Visible = false;
                    break;

                case 2:
                    btn_BorrarSelec.Visible = false;
                    btnOtroLibro.Visible = false;
                    gb_metodoPago.Visible = false;
                    break;
            }
        }

        //Boton para cancelar compra y cerra programa
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro que deseas cancelar tu compra?",
                "Precaución", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }   
        }

        //Boton para borrar el elemento seleccionado de la lista
        private void btn_BorrarSelec_Click(object sender, EventArgs e)
        {
            int indice = lista_NombreLibro.SelectedIndex;
            if(indice != -1)
            {
                subtotal -= double.Parse(lista_Precio.Items[indice].ToString());
                txt_subtotal.Text = $"L.{Math.Round(subtotal, 2)}";

                lista_NombreLibro.Items.RemoveAt(indice);
                lista_Precio.Items.RemoveAt(indice);
                lista_Tipo.Items.RemoveAt(indice);
            }
            else
            {
                errorProvider.SetError(btn_BorrarSelec, "Selecciona un libro de la lista superior");
            }
        }

        //Boton para borrar libro especificado antes de agregar a la lista
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txt_DescGeneral.Clear();
            Invisibles(1);
            btnEleccion.Visible = true;
        }

        //Seleccionar libros de la lista
        private void lista_Tipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(btn_BorrarSelec, "");
            int indice = lista_Tipo.SelectedIndex;
            lista_Precio.SelectedIndex = indice;
            lista_NombreLibro.SelectedIndex = indice;
        }

        private void lista_NombreLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(btn_BorrarSelec, "");
            int indice = lista_NombreLibro.SelectedIndex;
            lista_Precio.SelectedIndex = indice;
            lista_Tipo.SelectedIndex = indice;
        }

        private void lista_Precio_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(btn_BorrarSelec, "");
            int indice = lista_Precio.SelectedIndex;
            lista_Tipo.SelectedIndex = indice;
            lista_NombreLibro.SelectedIndex = indice;
        }//++++++++++++


        //Evento cuando el combobox cambia 
        private void cb_TipoLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(cb_TipoLibro, "");
        }

        //Eliminar error de falta de metodo de pago
        private void rb_tarjeta_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(gb_metodoPago, "");
        }

        private void rb_Efectivo_CheckedChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(gb_metodoPago, "");
        }
    }
}
