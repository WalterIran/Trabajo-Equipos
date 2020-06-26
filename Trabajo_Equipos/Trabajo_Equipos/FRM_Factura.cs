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
    public partial class FRM_Factura : Form
    {
        //comentario
        CLS_Texto libro = new CLS_Texto();

        public FRM_Factura()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Finalizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El total a pagar es de: " + txt_Total.Text, "Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }

        //Boton calcular innecesario
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        //carga de datos 
        private void FRM_Factura_Load(object sender, EventArgs e)
        {
            this.Text = DateTime.Today.ToShortDateString();

            txt_NombreCliente.Text = " ";
            txt_Telefono.Text = " ";
            txt_Edad.Text = " ";
            txt_Detalle.Text = " ";

            int edad = 60;
            int metodoPago = 0;

            if (edad > 59)
            {
                txt_Descuento.Text = $"{Math.Round((libro.CalculoSubtotal() * 0.25), 2)}";
            }
            else
            {
                txt_Descuento.Text = "0.00;";
            }

            double total = 800;
            double comision = 0;
            double isv = 0;

            switch (metodoPago)
            {
                case 1:
                    txt_Isv.Text = $"{Math.Round((total - double.Parse(txt_Descuento.Text)) * 0.15, 2)}";
                    break;
                default:
                    comision = Math.Round((total - double.Parse(txt_Descuento.Text)) * 0.03, 2);
                    isv = Math.Round((total - double.Parse(txt_Descuento.Text)) * 0.15, 2);
                    txt_Isv.Text = $"{comision + isv}";
                    break;

            }

            txt_Total.Text = $"{Math.Round((total - double.Parse(txt_Descuento.Text)) + double.Parse(txt_Isv.Text), 2)}";

        }
    }
}
