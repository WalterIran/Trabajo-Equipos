namespace Trabajo_Equipos
{
    partial class FRM_Nucleo
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
            this.components = new System.ComponentModel.Container();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ContenedorPrincipal = new System.Windows.Forms.SplitContainer();
            this.Contenido = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_TipoLibro = new System.Windows.Forms.ComboBox();
            this.btnEleccion = new System.Windows.Forms.Button();
            this.txt_DescGeneral = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lista_Tipo = new System.Windows.Forms.ListBox();
            this.lista_NombreLibro = new System.Windows.Forms.ListBox();
            this.lista_Precio = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOtroLibro = new System.Windows.Forms.Button();
            this.btn_BorrarSelec = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gb_metodoPago = new System.Windows.Forms.GroupBox();
            this.rb_Efectivo = new System.Windows.Forms.RadioButton();
            this.rb_tarjeta = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContenedorPrincipal)).BeginInit();
            this.ContenedorPrincipal.Panel1.SuspendLayout();
            this.ContenedorPrincipal.Panel2.SuspendLayout();
            this.ContenedorPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Contenido)).BeginInit();
            this.Contenido.Panel1.SuspendLayout();
            this.Contenido.Panel2.SuspendLayout();
            this.Contenido.SuspendLayout();
            this.gb_metodoPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ContenedorPrincipal
            // 
            this.ContenedorPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenedorPrincipal.Location = new System.Drawing.Point(0, 0);
            this.ContenedorPrincipal.Name = "ContenedorPrincipal";
            this.ContenedorPrincipal.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ContenedorPrincipal.Panel1
            // 
            this.ContenedorPrincipal.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ContenedorPrincipal.Panel1.Controls.Add(this.label1);
            // 
            // ContenedorPrincipal.Panel2
            // 
            this.ContenedorPrincipal.Panel2.Controls.Add(this.Contenido);
            this.ContenedorPrincipal.Size = new System.Drawing.Size(1129, 664);
            this.ContenedorPrincipal.SplitterDistance = 66;
            this.ContenedorPrincipal.TabIndex = 0;
            // 
            // Contenido
            // 
            this.Contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenido.Location = new System.Drawing.Point(0, 0);
            this.Contenido.Name = "Contenido";
            // 
            // Contenido.Panel1
            // 
            this.Contenido.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Contenido.Panel1.Controls.Add(this.btnCancelar);
            this.Contenido.Panel1.Controls.Add(this.btnBorrar);
            this.Contenido.Panel1.Controls.Add(this.btnAdicionar);
            this.Contenido.Panel1.Controls.Add(this.txt_DescGeneral);
            this.Contenido.Panel1.Controls.Add(this.btnEleccion);
            this.Contenido.Panel1.Controls.Add(this.cb_TipoLibro);
            this.Contenido.Panel1.Controls.Add(this.label2);
            // 
            // Contenido.Panel2
            // 
            this.Contenido.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Contenido.Panel2.Controls.Add(this.gb_metodoPago);
            this.Contenido.Panel2.Controls.Add(this.txt_subtotal);
            this.Contenido.Panel2.Controls.Add(this.label7);
            this.Contenido.Panel2.Controls.Add(this.btnFinalizar);
            this.Contenido.Panel2.Controls.Add(this.btn_BorrarSelec);
            this.Contenido.Panel2.Controls.Add(this.btnOtroLibro);
            this.Contenido.Panel2.Controls.Add(this.label6);
            this.Contenido.Panel2.Controls.Add(this.label5);
            this.Contenido.Panel2.Controls.Add(this.label4);
            this.Contenido.Panel2.Controls.Add(this.lista_Precio);
            this.Contenido.Panel2.Controls.Add(this.lista_NombreLibro);
            this.Contenido.Panel2.Controls.Add(this.lista_Tipo);
            this.Contenido.Panel2.Controls.Add(this.label3);
            this.Contenido.Size = new System.Drawing.Size(1129, 594);
            this.Contenido.SplitterDistance = 529;
            this.Contenido.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(365, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Librería los Cholos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo de libro:";
            // 
            // cb_TipoLibro
            // 
            this.cb_TipoLibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TipoLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TipoLibro.FormattingEnabled = true;
            this.cb_TipoLibro.Items.AddRange(new object[] {
            "Textos",
            "Novelas",
            "Cuentos"});
            this.cb_TipoLibro.Location = new System.Drawing.Point(183, 35);
            this.cb_TipoLibro.Name = "cb_TipoLibro";
            this.cb_TipoLibro.Size = new System.Drawing.Size(267, 33);
            this.cb_TipoLibro.TabIndex = 1;
            this.cb_TipoLibro.SelectedIndexChanged += new System.EventHandler(this.cb_TipoLibro_SelectedIndexChanged);
            // 
            // btnEleccion
            // 
            this.btnEleccion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEleccion.Location = new System.Drawing.Point(344, 82);
            this.btnEleccion.Name = "btnEleccion";
            this.btnEleccion.Size = new System.Drawing.Size(106, 34);
            this.btnEleccion.TabIndex = 2;
            this.btnEleccion.Text = "Elegir";
            this.btnEleccion.UseVisualStyleBackColor = true;
            this.btnEleccion.Click += new System.EventHandler(this.btnEleccion_Click);
            // 
            // txt_DescGeneral
            // 
            this.txt_DescGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DescGeneral.Location = new System.Drawing.Point(34, 133);
            this.txt_DescGeneral.Multiline = true;
            this.txt_DescGeneral.Name = "txt_DescGeneral";
            this.txt_DescGeneral.Size = new System.Drawing.Size(471, 314);
            this.txt_DescGeneral.TabIndex = 3;
            this.txt_DescGeneral.Visible = false;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(373, 459);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(114, 63);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Visible = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(204, 459);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(121, 63);
            this.btnBorrar.TabIndex = 5;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Visible = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(157, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Listado de libros adicionados";
            // 
            // lista_Tipo
            // 
            this.lista_Tipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lista_Tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista_Tipo.FormattingEnabled = true;
            this.lista_Tipo.ItemHeight = 25;
            this.lista_Tipo.Location = new System.Drawing.Point(30, 96);
            this.lista_Tipo.Name = "lista_Tipo";
            this.lista_Tipo.Size = new System.Drawing.Size(167, 304);
            this.lista_Tipo.TabIndex = 1;
            this.lista_Tipo.SelectedIndexChanged += new System.EventHandler(this.lista_Tipo_SelectedIndexChanged);
            // 
            // lista_NombreLibro
            // 
            this.lista_NombreLibro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lista_NombreLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista_NombreLibro.FormattingEnabled = true;
            this.lista_NombreLibro.ItemHeight = 25;
            this.lista_NombreLibro.Location = new System.Drawing.Point(221, 96);
            this.lista_NombreLibro.Name = "lista_NombreLibro";
            this.lista_NombreLibro.Size = new System.Drawing.Size(167, 304);
            this.lista_NombreLibro.TabIndex = 2;
            this.lista_NombreLibro.SelectedIndexChanged += new System.EventHandler(this.lista_NombreLibro_SelectedIndexChanged);
            // 
            // lista_Precio
            // 
            this.lista_Precio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lista_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lista_Precio.FormattingEnabled = true;
            this.lista_Precio.ItemHeight = 25;
            this.lista_Precio.Location = new System.Drawing.Point(406, 96);
            this.lista_Precio.Name = "lista_Precio";
            this.lista_Precio.Size = new System.Drawing.Size(167, 304);
            this.lista_Precio.TabIndex = 3;
            this.lista_Precio.SelectedIndexChanged += new System.EventHandler(this.lista_Precio_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo Libro:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(241, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nombre Libro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(449, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Precio:";
            // 
            // btnOtroLibro
            // 
            this.btnOtroLibro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOtroLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOtroLibro.Location = new System.Drawing.Point(45, 523);
            this.btnOtroLibro.Name = "btnOtroLibro";
            this.btnOtroLibro.Size = new System.Drawing.Size(139, 59);
            this.btnOtroLibro.TabIndex = 7;
            this.btnOtroLibro.Text = "Agregar otro libro";
            this.btnOtroLibro.UseVisualStyleBackColor = true;
            this.btnOtroLibro.Visible = false;
            this.btnOtroLibro.Click += new System.EventHandler(this.btnOtroLibro_Click);
            // 
            // btn_BorrarSelec
            // 
            this.btn_BorrarSelec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BorrarSelec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BorrarSelec.Location = new System.Drawing.Point(246, 523);
            this.btn_BorrarSelec.Name = "btn_BorrarSelec";
            this.btn_BorrarSelec.Size = new System.Drawing.Size(137, 59);
            this.btn_BorrarSelec.TabIndex = 8;
            this.btn_BorrarSelec.Text = "Borrar Selección";
            this.btn_BorrarSelec.UseVisualStyleBackColor = true;
            this.btn_BorrarSelec.Visible = false;
            this.btn_BorrarSelec.Click += new System.EventHandler(this.btn_BorrarSelec_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(424, 523);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(131, 59);
            this.btnFinalizar.TabIndex = 9;
            this.btnFinalizar.Text = "Finalizar compra";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Visible = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(298, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Subtotal:";
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_subtotal.Location = new System.Drawing.Point(406, 417);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.ReadOnly = true;
            this.txt_subtotal.Size = new System.Drawing.Size(167, 30);
            this.txt_subtotal.TabIndex = 11;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(48, 459);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 63);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar compra";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gb_metodoPago
            // 
            this.gb_metodoPago.Controls.Add(this.rb_tarjeta);
            this.gb_metodoPago.Controls.Add(this.rb_Efectivo);
            this.gb_metodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_metodoPago.Location = new System.Drawing.Point(30, 417);
            this.gb_metodoPago.Name = "gb_metodoPago";
            this.gb_metodoPago.Size = new System.Drawing.Size(262, 100);
            this.gb_metodoPago.TabIndex = 12;
            this.gb_metodoPago.TabStop = false;
            this.gb_metodoPago.Text = "Método de pago";
            this.gb_metodoPago.Visible = false;
            // 
            // rb_Efectivo
            // 
            this.rb_Efectivo.AutoSize = true;
            this.rb_Efectivo.Location = new System.Drawing.Point(6, 29);
            this.rb_Efectivo.Name = "rb_Efectivo";
            this.rb_Efectivo.Size = new System.Drawing.Size(102, 29);
            this.rb_Efectivo.TabIndex = 0;
            this.rb_Efectivo.TabStop = true;
            this.rb_Efectivo.Text = "Efectivo";
            this.rb_Efectivo.UseVisualStyleBackColor = true;
            this.rb_Efectivo.CheckedChanged += new System.EventHandler(this.rb_Efectivo_CheckedChanged);
            // 
            // rb_tarjeta
            // 
            this.rb_tarjeta.AutoSize = true;
            this.rb_tarjeta.Location = new System.Drawing.Point(6, 64);
            this.rb_tarjeta.Name = "rb_tarjeta";
            this.rb_tarjeta.Size = new System.Drawing.Size(162, 29);
            this.rb_tarjeta.TabIndex = 1;
            this.rb_tarjeta.TabStop = true;
            this.rb_tarjeta.Text = "Tarjeta Crédito";
            this.rb_tarjeta.UseVisualStyleBackColor = true;
            this.rb_tarjeta.CheckedChanged += new System.EventHandler(this.rb_tarjeta_CheckedChanged);
            // 
            // FRM_Nucleo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1129, 664);
            this.Controls.Add(this.ContenedorPrincipal);
            this.Name = "FRM_Nucleo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elección de Libros";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ContenedorPrincipal.Panel1.ResumeLayout(false);
            this.ContenedorPrincipal.Panel1.PerformLayout();
            this.ContenedorPrincipal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContenedorPrincipal)).EndInit();
            this.ContenedorPrincipal.ResumeLayout(false);
            this.Contenido.Panel1.ResumeLayout(false);
            this.Contenido.Panel1.PerformLayout();
            this.Contenido.Panel2.ResumeLayout(false);
            this.Contenido.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Contenido)).EndInit();
            this.Contenido.ResumeLayout(false);
            this.gb_metodoPago.ResumeLayout(false);
            this.gb_metodoPago.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.SplitContainer ContenedorPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer Contenido;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txt_DescGeneral;
        private System.Windows.Forms.Button btnEleccion;
        private System.Windows.Forms.ComboBox cb_TipoLibro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btn_BorrarSelec;
        private System.Windows.Forms.Button btnOtroLibro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lista_Precio;
        private System.Windows.Forms.ListBox lista_NombreLibro;
        private System.Windows.Forms.ListBox lista_Tipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gb_metodoPago;
        private System.Windows.Forms.RadioButton rb_tarjeta;
        private System.Windows.Forms.RadioButton rb_Efectivo;
    }
}