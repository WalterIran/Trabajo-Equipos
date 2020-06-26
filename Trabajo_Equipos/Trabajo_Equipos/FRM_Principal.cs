using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Equipos
{
    public partial class FRM_Principal : Form
    {
        FRM_Factura frmfactura = new FRM_Factura();

        public FRM_Principal()
        {
            InitializeComponent();
            dateTimePicker_Nacimiento.MaxDate = DateTime.Now.AddYears(-18);
        }

        CLS_Validaciones validacion = new CLS_Validaciones();
        const int cantTxtNumeros = 1;
        const int cantTxtLetras = 1;

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            TextBox[] textoLetras = new TextBox[] { txt_NombreCliente};
            TextBox[] textoNumeros = new TextBox[] { txt_NumTelefono };

            if (validacion.soloNumeros(errorProvider, textoNumeros, cantTxtNumeros)
                && validacion.SoloLetras(errorProvider,textoLetras, cantTxtLetras))
            {
                MessageBox.Show("Listo");
                frmfactura.ShowDialog();
            }

            

        }
    }
}
