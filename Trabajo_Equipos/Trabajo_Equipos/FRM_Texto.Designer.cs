namespace Trabajo_Equipos
{
    partial class FRM_Texto
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
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_Categoria = new System.Windows.Forms.Label();
            this.lbl_TituloLibro = new System.Windows.Forms.Label();
            this.lbl_NombreAutor = new System.Windows.Forms.Label();
            this.lbl_NombreEditorial = new System.Windows.Forms.Label();
            this.lbl_Edicion = new System.Windows.Forms.Label();
            this.lbl_PrecioBase = new System.Windows.Forms.Label();
            this.lbl_PrecioAdicional = new System.Windows.Forms.Label();
            this.lbl_Subtotal = new System.Windows.Forms.Label();
            this.cb_Categoria = new System.Windows.Forms.ComboBox();
            this.txt_TituloLibro = new System.Windows.Forms.TextBox();
            this.txt_Autor = new System.Windows.Forms.TextBox();
            this.txt_Editorial = new System.Windows.Forms.TextBox();
            this.nup_Edicion = new System.Windows.Forms.NumericUpDown();
            this.txt_PrecioBase = new System.Windows.Forms.Label();
            this.txt_PrecioAdicion = new System.Windows.Forms.Label();
            this.txt_SubtotalTexto = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_Limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nup_Edicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(149, 20);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(161, 24);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "Libros de Texto";
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.AutoSize = true;
            this.lbl_Categoria.Location = new System.Drawing.Point(64, 71);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(59, 17);
            this.lbl_Categoria.TabIndex = 1;
            this.lbl_Categoria.Text = "Materia:";
            // 
            // lbl_TituloLibro
            // 
            this.lbl_TituloLibro.AutoSize = true;
            this.lbl_TituloLibro.Location = new System.Drawing.Point(64, 114);
            this.lbl_TituloLibro.Name = "lbl_TituloLibro";
            this.lbl_TituloLibro.Size = new System.Drawing.Size(83, 17);
            this.lbl_TituloLibro.TabIndex = 2;
            this.lbl_TituloLibro.Text = "Titulo Libro:";
            // 
            // lbl_NombreAutor
            // 
            this.lbl_NombreAutor.AutoSize = true;
            this.lbl_NombreAutor.Location = new System.Drawing.Point(64, 161);
            this.lbl_NombreAutor.Name = "lbl_NombreAutor";
            this.lbl_NombreAutor.Size = new System.Drawing.Size(100, 17);
            this.lbl_NombreAutor.TabIndex = 3;
            this.lbl_NombreAutor.Text = "Nombre Autor:";
            // 
            // lbl_NombreEditorial
            // 
            this.lbl_NombreEditorial.AutoSize = true;
            this.lbl_NombreEditorial.Location = new System.Drawing.Point(64, 210);
            this.lbl_NombreEditorial.Name = "lbl_NombreEditorial";
            this.lbl_NombreEditorial.Size = new System.Drawing.Size(117, 17);
            this.lbl_NombreEditorial.TabIndex = 4;
            this.lbl_NombreEditorial.Text = "Nombre Editorial:";
            // 
            // lbl_Edicion
            // 
            this.lbl_Edicion.AutoSize = true;
            this.lbl_Edicion.Location = new System.Drawing.Point(64, 260);
            this.lbl_Edicion.Name = "lbl_Edicion";
            this.lbl_Edicion.Size = new System.Drawing.Size(58, 17);
            this.lbl_Edicion.TabIndex = 5;
            this.lbl_Edicion.Text = "Edicion:";
            // 
            // lbl_PrecioBase
            // 
            this.lbl_PrecioBase.AutoSize = true;
            this.lbl_PrecioBase.Location = new System.Drawing.Point(64, 316);
            this.lbl_PrecioBase.Name = "lbl_PrecioBase";
            this.lbl_PrecioBase.Size = new System.Drawing.Size(52, 17);
            this.lbl_PrecioBase.TabIndex = 6;
            this.lbl_PrecioBase.Text = "Precio:";
            this.lbl_PrecioBase.Visible = false;
            // 
            // lbl_PrecioAdicional
            // 
            this.lbl_PrecioAdicional.AutoSize = true;
            this.lbl_PrecioAdicional.Location = new System.Drawing.Point(215, 316);
            this.lbl_PrecioAdicional.Name = "lbl_PrecioAdicional";
            this.lbl_PrecioAdicional.Size = new System.Drawing.Size(113, 17);
            this.lbl_PrecioAdicional.TabIndex = 7;
            this.lbl_PrecioAdicional.Text = "Precio Adicional:";
            this.lbl_PrecioAdicional.Visible = false;
            // 
            // lbl_Subtotal
            // 
            this.lbl_Subtotal.AutoSize = true;
            this.lbl_Subtotal.Location = new System.Drawing.Point(64, 353);
            this.lbl_Subtotal.Name = "lbl_Subtotal";
            this.lbl_Subtotal.Size = new System.Drawing.Size(64, 17);
            this.lbl_Subtotal.TabIndex = 8;
            this.lbl_Subtotal.Text = "Subtotal:";
            this.lbl_Subtotal.Visible = false;
            // 
            // cb_Categoria
            // 
            this.cb_Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Categoria.FormattingEnabled = true;
            this.cb_Categoria.Location = new System.Drawing.Point(129, 68);
            this.cb_Categoria.Name = "cb_Categoria";
            this.cb_Categoria.Size = new System.Drawing.Size(225, 24);
            this.cb_Categoria.TabIndex = 9;
            this.cb_Categoria.SelectedIndexChanged += new System.EventHandler(this.cb_Categoria_SelectedIndexChanged);
            // 
            // txt_TituloLibro
            // 
            this.txt_TituloLibro.Location = new System.Drawing.Point(153, 109);
            this.txt_TituloLibro.Name = "txt_TituloLibro";
            this.txt_TituloLibro.Size = new System.Drawing.Size(296, 22);
            this.txt_TituloLibro.TabIndex = 11;
            // 
            // txt_Autor
            // 
            this.txt_Autor.Location = new System.Drawing.Point(170, 161);
            this.txt_Autor.Name = "txt_Autor";
            this.txt_Autor.Size = new System.Drawing.Size(237, 22);
            this.txt_Autor.TabIndex = 12;
            // 
            // txt_Editorial
            // 
            this.txt_Editorial.Location = new System.Drawing.Point(187, 207);
            this.txt_Editorial.Name = "txt_Editorial";
            this.txt_Editorial.Size = new System.Drawing.Size(220, 22);
            this.txt_Editorial.TabIndex = 13;
            this.txt_Editorial.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // nup_Edicion
            // 
            this.nup_Edicion.Location = new System.Drawing.Point(128, 258);
            this.nup_Edicion.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nup_Edicion.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nup_Edicion.Name = "nup_Edicion";
            this.nup_Edicion.Size = new System.Drawing.Size(67, 22);
            this.nup_Edicion.TabIndex = 14;
            this.nup_Edicion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nup_Edicion.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nup_Edicion.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nup_Edicion.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // txt_PrecioBase
            // 
            this.txt_PrecioBase.AutoSize = true;
            this.txt_PrecioBase.Location = new System.Drawing.Point(122, 316);
            this.txt_PrecioBase.Name = "txt_PrecioBase";
            this.txt_PrecioBase.Size = new System.Drawing.Size(18, 17);
            this.txt_PrecioBase.TabIndex = 15;
            this.txt_PrecioBase.Text = "--";
            this.txt_PrecioBase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_PrecioBase.Visible = false;
            // 
            // txt_PrecioAdicion
            // 
            this.txt_PrecioAdicion.AutoSize = true;
            this.txt_PrecioAdicion.Location = new System.Drawing.Point(334, 316);
            this.txt_PrecioAdicion.Name = "txt_PrecioAdicion";
            this.txt_PrecioAdicion.Size = new System.Drawing.Size(18, 17);
            this.txt_PrecioAdicion.TabIndex = 16;
            this.txt_PrecioAdicion.Text = "--";
            this.txt_PrecioAdicion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_PrecioAdicion.Visible = false;
            // 
            // txt_SubtotalTexto
            // 
            this.txt_SubtotalTexto.AutoSize = true;
            this.txt_SubtotalTexto.Location = new System.Drawing.Point(134, 353);
            this.txt_SubtotalTexto.Name = "txt_SubtotalTexto";
            this.txt_SubtotalTexto.Size = new System.Drawing.Size(18, 17);
            this.txt_SubtotalTexto.TabIndex = 17;
            this.txt_SubtotalTexto.Text = "--";
            this.txt_SubtotalTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_SubtotalTexto.Visible = false;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(308, 398);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(90, 29);
            this.btn_Aceptar.TabIndex = 18;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Visible = false;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(178, 398);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(99, 29);
            this.btn_Cancelar.TabIndex = 19;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.Location = new System.Drawing.Point(59, 398);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(93, 29);
            this.btn_Limpiar.TabIndex = 20;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = true;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // FRM_Texto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(482, 464);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.txt_SubtotalTexto);
            this.Controls.Add(this.txt_PrecioAdicion);
            this.Controls.Add(this.txt_PrecioBase);
            this.Controls.Add(this.nup_Edicion);
            this.Controls.Add(this.txt_Editorial);
            this.Controls.Add(this.txt_Autor);
            this.Controls.Add(this.txt_TituloLibro);
            this.Controls.Add(this.cb_Categoria);
            this.Controls.Add(this.lbl_Subtotal);
            this.Controls.Add(this.lbl_PrecioAdicional);
            this.Controls.Add(this.lbl_PrecioBase);
            this.Controls.Add(this.lbl_Edicion);
            this.Controls.Add(this.lbl_NombreEditorial);
            this.Controls.Add(this.lbl_NombreAutor);
            this.Controls.Add(this.lbl_TituloLibro);
            this.Controls.Add(this.lbl_Categoria);
            this.Controls.Add(this.lbl_Titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FRM_Texto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana Texto";
            this.Load += new System.EventHandler(this.FRM_Texto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nup_Edicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_Categoria;
        private System.Windows.Forms.Label lbl_TituloLibro;
        private System.Windows.Forms.Label lbl_NombreAutor;
        private System.Windows.Forms.Label lbl_NombreEditorial;
        private System.Windows.Forms.Label lbl_Edicion;
        private System.Windows.Forms.Label lbl_PrecioBase;
        private System.Windows.Forms.Label lbl_PrecioAdicional;
        private System.Windows.Forms.Label lbl_Subtotal;
        private System.Windows.Forms.ComboBox cb_Categoria;
        private System.Windows.Forms.TextBox txt_TituloLibro;
        private System.Windows.Forms.TextBox txt_Autor;
        private System.Windows.Forms.TextBox txt_Editorial;
        private System.Windows.Forms.NumericUpDown nup_Edicion;
        private System.Windows.Forms.Label txt_PrecioBase;
        private System.Windows.Forms.Label txt_PrecioAdicion;
        private System.Windows.Forms.Label txt_SubtotalTexto;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btn_Limpiar;
    }
}