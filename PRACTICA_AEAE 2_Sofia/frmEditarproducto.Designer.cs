namespace PRACTICA_AEAE_2_Sofia
{
    partial class frmEditarproducto
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
            this.Titulo = new System.Windows.Forms.Label();
            this.pnlactualizarclientes = new System.Windows.Forms.Panel();
            this.txtCantidad = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrecioV = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtPrecioC = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCodigo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNombrep = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnActualizar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pnlactualizarclientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.Maroon;
            this.Titulo.Location = new System.Drawing.Point(196, 90);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(100, 25);
            this.Titulo.TabIndex = 2;
            this.Titulo.Text = "Productos";
            this.Titulo.Click += new System.EventHandler(this.Titulo_Click);
            // 
            // pnlactualizarclientes
            // 
            this.pnlactualizarclientes.Controls.Add(this.txtCantidad);
            this.pnlactualizarclientes.Controls.Add(this.txtPrecioV);
            this.pnlactualizarclientes.Controls.Add(this.txtPrecioC);
            this.pnlactualizarclientes.Controls.Add(this.txtCodigo);
            this.pnlactualizarclientes.Controls.Add(this.txtNombrep);
            this.pnlactualizarclientes.Location = new System.Drawing.Point(32, 156);
            this.pnlactualizarclientes.Name = "pnlactualizarclientes";
            this.pnlactualizarclientes.Size = new System.Drawing.Size(426, 184);
            this.pnlactualizarclientes.TabIndex = 3;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Depth = 0;
            this.txtCantidad.Hint = "Cantidad Stock";
            this.txtCantidad.Location = new System.Drawing.Point(34, 137);
            this.txtCantidad.MaxLength = 32767;
            this.txtCantidad.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PasswordChar = '\0';
            this.txtCantidad.SelectedText = "";
            this.txtCantidad.SelectionLength = 0;
            this.txtCantidad.SelectionStart = 0;
            this.txtCantidad.Size = new System.Drawing.Size(266, 23);
            this.txtCantidad.TabIndex = 4;
            this.txtCantidad.TabStop = false;
            this.txtCantidad.UseSystemPasswordChar = false;
            // 
            // txtPrecioV
            // 
            this.txtPrecioV.Depth = 0;
            this.txtPrecioV.Hint = "Precio Venta";
            this.txtPrecioV.Location = new System.Drawing.Point(34, 108);
            this.txtPrecioV.MaxLength = 32767;
            this.txtPrecioV.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecioV.Name = "txtPrecioV";
            this.txtPrecioV.PasswordChar = '\0';
            this.txtPrecioV.SelectedText = "";
            this.txtPrecioV.SelectionLength = 0;
            this.txtPrecioV.SelectionStart = 0;
            this.txtPrecioV.Size = new System.Drawing.Size(266, 23);
            this.txtPrecioV.TabIndex = 3;
            this.txtPrecioV.TabStop = false;
            this.txtPrecioV.UseSystemPasswordChar = false;
            // 
            // txtPrecioC
            // 
            this.txtPrecioC.Depth = 0;
            this.txtPrecioC.Hint = "Precio Compra";
            this.txtPrecioC.Location = new System.Drawing.Point(34, 79);
            this.txtPrecioC.MaxLength = 32767;
            this.txtPrecioC.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPrecioC.Name = "txtPrecioC";
            this.txtPrecioC.PasswordChar = '\0';
            this.txtPrecioC.SelectedText = "";
            this.txtPrecioC.SelectionLength = 0;
            this.txtPrecioC.SelectionStart = 0;
            this.txtPrecioC.Size = new System.Drawing.Size(266, 23);
            this.txtPrecioC.TabIndex = 2;
            this.txtPrecioC.TabStop = false;
            this.txtPrecioC.UseSystemPasswordChar = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Depth = 0;
            this.txtCodigo.Hint = "Código Referencia";
            this.txtCodigo.Location = new System.Drawing.Point(34, 50);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.Size = new System.Drawing.Size(266, 23);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.UseSystemPasswordChar = false;
            // 
            // txtNombrep
            // 
            this.txtNombrep.Depth = 0;
            this.txtNombrep.Hint = "Nombre Producto";
            this.txtNombrep.Location = new System.Drawing.Point(34, 21);
            this.txtNombrep.MaxLength = 32767;
            this.txtNombrep.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombrep.Name = "txtNombrep";
            this.txtNombrep.PasswordChar = '\0';
            this.txtNombrep.SelectedText = "";
            this.txtNombrep.SelectionLength = 0;
            this.txtNombrep.SelectionStart = 0;
            this.txtNombrep.Size = new System.Drawing.Size(266, 23);
            this.txtNombrep.TabIndex = 0;
            this.txtNombrep.TabStop = false;
            this.txtNombrep.Tag = "";
            this.txtNombrep.UseSystemPasswordChar = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(66, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(41, 20);
            this.textBox1.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.AutoSize = true;
            this.btnSalir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalir.Depth = 0;
            this.btnSalir.Icon = null;
            this.btnSalir.Location = new System.Drawing.Point(319, 365);
            this.btnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Primary = true;
            this.btnSalir.Size = new System.Drawing.Size(58, 36);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.TabStop = false;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseCompatibleTextRendering = true;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSize = true;
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Depth = 0;
            this.btnActualizar.Icon = null;
            this.btnActualizar.Location = new System.Drawing.Point(159, 365);
            this.btnActualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Primary = true;
            this.btnActualizar.Size = new System.Drawing.Size(103, 36);
            this.btnActualizar.TabIndex = 5;
            this.btnActualizar.TabStop = false;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseCompatibleTextRendering = true;
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // frmEditarproducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pnlactualizarclientes);
            this.Controls.Add(this.Titulo);
            this.Name = "frmEditarproducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de productos";
            this.pnlactualizarclientes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Panel pnlactualizarclientes;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCantidad;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecioV;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPrecioC;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodigo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombrep;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialRaisedButton btnSalir;
        private MaterialSkin.Controls.MaterialRaisedButton btnActualizar;
    }
}