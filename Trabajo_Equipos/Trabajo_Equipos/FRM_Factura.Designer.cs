namespace Trabajo_Equipos
{
    partial class FRM_Factura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Finalizar = new System.Windows.Forms.Button();
            this.txt_Total = new System.Windows.Forms.Label();
            this.txt_Descuento = new System.Windows.Forms.Label();
            this.txt_SubtotalTexto = new System.Windows.Forms.Label();
            this.lbl_Subtotal = new System.Windows.Forms.Label();
            this.lbl_PrecioAdicional = new System.Windows.Forms.Label();
            this.lbl_PrecioBase = new System.Windows.Forms.Label();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.lbl_NombreCliente = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.txt_Detalle = new System.Windows.Forms.TextBox();
            this.txt_NombreCliente = new System.Windows.Forms.Label();
            this.txt_Telefono = new System.Windows.Forms.Label();
            this.txt_Precios = new System.Windows.Forms.TextBox();
            this.lbl_Edad = new System.Windows.Forms.Label();
            this.txt_Edad = new System.Windows.Forms.Label();
            this.txt_Isv = new System.Windows.Forms.Label();
            this.lbl_Isv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(22, 506);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(99, 29);
            this.btn_Cancelar.TabIndex = 39;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Finalizar
            // 
            this.btn_Finalizar.Location = new System.Drawing.Point(224, 506);
            this.btn_Finalizar.Name = "btn_Finalizar";
            this.btn_Finalizar.Size = new System.Drawing.Size(90, 29);
            this.btn_Finalizar.TabIndex = 38;
            this.btn_Finalizar.Text = "Finalizar";
            this.btn_Finalizar.UseVisualStyleBackColor = true;
            this.btn_Finalizar.Click += new System.EventHandler(this.btn_Finalizar_Click);
            // 
            // txt_Total
            // 
            this.txt_Total.AutoSize = true;
            this.txt_Total.Location = new System.Drawing.Point(296, 465);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(18, 17);
            this.txt_Total.TabIndex = 37;
            this.txt_Total.Text = "--";
            this.txt_Total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_Total.Visible = false;
            // 
            // txt_Descuento
            // 
            this.txt_Descuento.AutoSize = true;
            this.txt_Descuento.Location = new System.Drawing.Point(296, 401);
            this.txt_Descuento.Name = "txt_Descuento";
            this.txt_Descuento.Size = new System.Drawing.Size(18, 17);
            this.txt_Descuento.TabIndex = 36;
            this.txt_Descuento.Text = "--";
            this.txt_Descuento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_Descuento.Visible = false;
            // 
            // txt_SubtotalTexto
            // 
            this.txt_SubtotalTexto.AutoSize = true;
            this.txt_SubtotalTexto.Location = new System.Drawing.Point(296, 374);
            this.txt_SubtotalTexto.Name = "txt_SubtotalTexto";
            this.txt_SubtotalTexto.Size = new System.Drawing.Size(18, 17);
            this.txt_SubtotalTexto.TabIndex = 35;
            this.txt_SubtotalTexto.Text = "--";
            this.txt_SubtotalTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_SubtotalTexto.Visible = false;
            // 
            // lbl_Subtotal
            // 
            this.lbl_Subtotal.AutoSize = true;
            this.lbl_Subtotal.Location = new System.Drawing.Point(226, 465);
            this.lbl_Subtotal.Name = "lbl_Subtotal";
            this.lbl_Subtotal.Size = new System.Drawing.Size(44, 17);
            this.lbl_Subtotal.TabIndex = 29;
            this.lbl_Subtotal.Text = "Total:";
            this.lbl_Subtotal.Visible = false;
            // 
            // lbl_PrecioAdicional
            // 
            this.lbl_PrecioAdicional.AutoSize = true;
            this.lbl_PrecioAdicional.Location = new System.Drawing.Point(190, 401);
            this.lbl_PrecioAdicional.Name = "lbl_PrecioAdicional";
            this.lbl_PrecioAdicional.Size = new System.Drawing.Size(80, 17);
            this.lbl_PrecioAdicional.TabIndex = 28;
            this.lbl_PrecioAdicional.Text = "Descuento:";
            this.lbl_PrecioAdicional.Visible = false;
            // 
            // lbl_PrecioBase
            // 
            this.lbl_PrecioBase.AutoSize = true;
            this.lbl_PrecioBase.Location = new System.Drawing.Point(206, 374);
            this.lbl_PrecioBase.Name = "lbl_PrecioBase";
            this.lbl_PrecioBase.Size = new System.Drawing.Size(64, 17);
            this.lbl_PrecioBase.TabIndex = 27;
            this.lbl_PrecioBase.Text = "Subtotal:";
            this.lbl_PrecioBase.Visible = false;
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Location = new System.Drawing.Point(12, 92);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(68, 17);
            this.lbl_Telefono.TabIndex = 23;
            this.lbl_Telefono.Text = "Teléfono:";
            // 
            // lbl_NombreCliente
            // 
            this.lbl_NombreCliente.AutoSize = true;
            this.lbl_NombreCliente.Location = new System.Drawing.Point(12, 61);
            this.lbl_NombreCliente.Name = "lbl_NombreCliente";
            this.lbl_NombreCliente.Size = new System.Drawing.Size(109, 17);
            this.lbl_NombreCliente.TabIndex = 22;
            this.lbl_NombreCliente.Text = "Nombre Cliente:";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(129, 28);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(87, 24);
            this.lbl_Titulo.TabIndex = 21;
            this.lbl_Titulo.Text = "Factura";
            // 
            // txt_Detalle
            // 
            this.txt_Detalle.Location = new System.Drawing.Point(15, 155);
            this.txt_Detalle.Multiline = true;
            this.txt_Detalle.Name = "txt_Detalle";
            this.txt_Detalle.Size = new System.Drawing.Size(217, 186);
            this.txt_Detalle.TabIndex = 41;
            // 
            // txt_NombreCliente
            // 
            this.txt_NombreCliente.AutoSize = true;
            this.txt_NombreCliente.Location = new System.Drawing.Point(127, 61);
            this.txt_NombreCliente.Name = "txt_NombreCliente";
            this.txt_NombreCliente.Size = new System.Drawing.Size(18, 17);
            this.txt_NombreCliente.TabIndex = 42;
            this.txt_NombreCliente.Text = "--";
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.AutoSize = true;
            this.txt_Telefono.Location = new System.Drawing.Point(86, 92);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(18, 17);
            this.txt_Telefono.TabIndex = 43;
            this.txt_Telefono.Text = "--";
            // 
            // txt_Precios
            // 
            this.txt_Precios.Location = new System.Drawing.Point(260, 155);
            this.txt_Precios.Multiline = true;
            this.txt_Precios.Name = "txt_Precios";
            this.txt_Precios.Size = new System.Drawing.Size(78, 186);
            this.txt_Precios.TabIndex = 44;
            this.txt_Precios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_Edad
            // 
            this.lbl_Edad.AutoSize = true;
            this.lbl_Edad.Location = new System.Drawing.Point(12, 120);
            this.lbl_Edad.Name = "lbl_Edad";
            this.lbl_Edad.Size = new System.Drawing.Size(45, 17);
            this.lbl_Edad.TabIndex = 46;
            this.lbl_Edad.Text = "Edad:";
            // 
            // txt_Edad
            // 
            this.txt_Edad.AutoSize = true;
            this.txt_Edad.Location = new System.Drawing.Point(63, 120);
            this.txt_Edad.Name = "txt_Edad";
            this.txt_Edad.Size = new System.Drawing.Size(18, 17);
            this.txt_Edad.TabIndex = 47;
            this.txt_Edad.Text = "--";
            // 
            // txt_Isv
            // 
            this.txt_Isv.AutoSize = true;
            this.txt_Isv.Location = new System.Drawing.Point(296, 434);
            this.txt_Isv.Name = "txt_Isv";
            this.txt_Isv.Size = new System.Drawing.Size(18, 17);
            this.txt_Isv.TabIndex = 49;
            this.txt_Isv.Text = "--";
            this.txt_Isv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_Isv.Visible = false;
            // 
            // lbl_Isv
            // 
            this.lbl_Isv.AutoSize = true;
            this.lbl_Isv.Location = new System.Drawing.Point(237, 434);
            this.lbl_Isv.Name = "lbl_Isv";
            this.lbl_Isv.Size = new System.Drawing.Size(33, 17);
            this.lbl_Isv.TabIndex = 48;
            this.lbl_Isv.Text = "ISV:";
            this.lbl_Isv.Visible = false;
            // 
            // FRM_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(377, 576);
            this.ControlBox = false;
            this.Controls.Add(this.txt_Isv);
            this.Controls.Add(this.lbl_Isv);
            this.Controls.Add(this.txt_Edad);
            this.Controls.Add(this.lbl_Edad);
            this.Controls.Add(this.txt_Precios);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.txt_NombreCliente);
            this.Controls.Add(this.txt_Detalle);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Finalizar);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.txt_Descuento);
            this.Controls.Add(this.txt_SubtotalTexto);
            this.Controls.Add(this.lbl_Subtotal);
            this.Controls.Add(this.lbl_PrecioAdicional);
            this.Controls.Add(this.lbl_PrecioBase);
            this.Controls.Add(this.lbl_Telefono);
            this.Controls.Add(this.lbl_NombreCliente);
            this.Controls.Add(this.lbl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FRM_Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.FRM_Factura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Finalizar;
        private System.Windows.Forms.Label txt_Total;
        private System.Windows.Forms.Label txt_Descuento;
        private System.Windows.Forms.Label txt_SubtotalTexto;
        private System.Windows.Forms.Label lbl_Subtotal;
        private System.Windows.Forms.Label lbl_PrecioAdicional;
        private System.Windows.Forms.Label lbl_PrecioBase;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.Label lbl_NombreCliente;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.TextBox txt_Detalle;
        private System.Windows.Forms.Label txt_NombreCliente;
        private System.Windows.Forms.Label txt_Telefono;
        private System.Windows.Forms.TextBox txt_Precios;
        private System.Windows.Forms.Label lbl_Edad;
        private System.Windows.Forms.Label txt_Edad;
        private System.Windows.Forms.Label txt_Isv;
        private System.Windows.Forms.Label lbl_Isv;
    }
}