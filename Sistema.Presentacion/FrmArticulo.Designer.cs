namespace Sistema.Presentacion
{
    partial class FrmArticulo
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
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtActualizar = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.BtInsertar = new System.Windows.Forms.Button();
            this.Txtid = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ChkSeleccionar = new System.Windows.Forms.CheckBox();
            this.DgvListado = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btEliminar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.CboCategoria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.TxtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbotalle = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbomarca = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(7, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 49;
            this.lblID.Text = "ID";
            this.lblID.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(500, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "(*) Son Obligatorios";
            // 
            // BtActualizar
            // 
            this.BtActualizar.BackColor = System.Drawing.Color.Gold;
            this.BtActualizar.Location = new System.Drawing.Point(558, 352);
            this.BtActualizar.Name = "BtActualizar";
            this.BtActualizar.Size = new System.Drawing.Size(154, 23);
            this.BtActualizar.TabIndex = 47;
            this.BtActualizar.Text = "Actualizar";
            this.BtActualizar.UseVisualStyleBackColor = false;
            this.BtActualizar.Click += new System.EventHandler(this.BtActualizar_Click);
            // 
            // BtCancelar
            // 
            this.BtCancelar.BackColor = System.Drawing.Color.SpringGreen;
            this.BtCancelar.Location = new System.Drawing.Point(788, 352);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(161, 23);
            this.BtCancelar.TabIndex = 46;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = false;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // BtInsertar
            // 
            this.BtInsertar.BackColor = System.Drawing.Color.Chocolate;
            this.BtInsertar.Location = new System.Drawing.Point(362, 352);
            this.BtInsertar.Name = "BtInsertar";
            this.BtInsertar.Size = new System.Drawing.Size(154, 23);
            this.BtInsertar.TabIndex = 45;
            this.BtInsertar.Text = "Insertar";
            this.BtInsertar.UseVisualStyleBackColor = false;
            this.BtInsertar.Click += new System.EventHandler(this.BtInsertar_Click);
            // 
            // Txtid
            // 
            this.Txtid.BackColor = System.Drawing.Color.White;
            this.Txtid.Location = new System.Drawing.Point(70, 9);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(44, 20);
            this.Txtid.TabIndex = 44;
            this.Txtid.Visible = false;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(65, 169);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(157, 20);
            this.TxtNombre.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Nombre(*)";
            // 
            // ChkSeleccionar
            // 
            this.ChkSeleccionar.AutoSize = true;
            this.ChkSeleccionar.Location = new System.Drawing.Point(1081, 293);
            this.ChkSeleccionar.Margin = new System.Windows.Forms.Padding(2);
            this.ChkSeleccionar.Name = "ChkSeleccionar";
            this.ChkSeleccionar.Size = new System.Drawing.Size(82, 17);
            this.ChkSeleccionar.TabIndex = 41;
            this.ChkSeleccionar.Text = "Seleccionar";
            this.ChkSeleccionar.UseVisualStyleBackColor = true;
            this.ChkSeleccionar.CheckedChanged += new System.EventHandler(this.Chkseleccionar_CheckedChanged);
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.AllowUserToOrderColumns = true;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.DgvListado.Location = new System.Drawing.Point(363, 55);
            this.DgvListado.Margin = new System.Windows.Forms.Padding(2);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowTemplate.Height = 24;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(779, 218);
            this.DgvListado.TabIndex = 40;
            this.DgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellContentClick);
            this.DgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListado_CellDoubleClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.Color.Salmon;
            this.btEliminar.Location = new System.Drawing.Point(996, 352);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(180, 23);
            this.btEliminar.TabIndex = 39;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(1025, 40);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 38;
            this.lblTotal.Text = "Total";
            // 
            // CboCategoria
            // 
            this.CboCategoria.FormattingEnabled = true;
            this.CboCategoria.Location = new System.Drawing.Point(80, 43);
            this.CboCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.CboCategoria.Name = "CboCategoria";
            this.CboCategoria.Size = new System.Drawing.Size(142, 21);
            this.CboCategoria.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Categoría (*)";
            // 
            // TxtStock
            // 
            this.TxtStock.Location = new System.Drawing.Point(80, 332);
            this.TxtStock.Margin = new System.Windows.Forms.Padding(2);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(92, 20);
            this.TxtStock.TabIndex = 55;
            // 
            // TxtPrecioVenta
            // 
            this.TxtPrecioVenta.Location = new System.Drawing.Point(107, 291);
            this.TxtPrecioVenta.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPrecioVenta.Name = "TxtPrecioVenta";
            this.TxtPrecioVenta.Size = new System.Drawing.Size(92, 20);
            this.TxtPrecioVenta.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 335);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Stock (*)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 291);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Precio Venta (*)";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(107, 244);
            this.txtPrecioCompra.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(92, 20);
            this.txtPrecioCompra.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 247);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Precio Compra(*)";
            // 
            // cbotalle
            // 
            this.cbotalle.FormattingEnabled = true;
            this.cbotalle.Location = new System.Drawing.Point(80, 125);
            this.cbotalle.Margin = new System.Windows.Forms.Padding(2);
            this.cbotalle.Name = "cbotalle";
            this.cbotalle.Size = new System.Drawing.Size(142, 21);
            this.cbotalle.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Talle (*)";
            // 
            // cbomarca
            // 
            this.cbomarca.FormattingEnabled = true;
            this.cbomarca.Location = new System.Drawing.Point(80, 85);
            this.cbomarca.Margin = new System.Windows.Forms.Padding(2);
            this.cbomarca.Name = "cbomarca";
            this.cbomarca.Size = new System.Drawing.Size(142, 21);
            this.cbomarca.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 60;
            this.label6.Text = "Marca (*)";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(80, 207);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(142, 20);
            this.txtCodigo.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 210);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 62;
            this.label9.Text = "Codigo (*)";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(80, 369);
            this.txtColor.Margin = new System.Windows.Forms.Padding(2);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(142, 20);
            this.txtColor.TabIndex = 65;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 372);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 64;
            this.label10.Text = "Color (*)";
            // 
            // FrmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1239, 421);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbomarca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbotalle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtStock);
            this.Controls.Add(this.TxtPrecioVenta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CboCategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtActualizar);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtInsertar);
            this.Controls.Add(this.Txtid);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChkSeleccionar);
            this.Controls.Add(this.DgvListado);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.lblTotal);
            this.Name = "FrmArticulo";
            this.Text = "FrmArticulo";
            this.Load += new System.EventHandler(this.FrmArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtActualizar;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.Button BtInsertar;
        private System.Windows.Forms.TextBox Txtid;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ChkSeleccionar;
        private System.Windows.Forms.DataGridView DgvListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.TextBox TxtPrecioVenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CboCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbomarca;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbotalle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label10;
    }
}