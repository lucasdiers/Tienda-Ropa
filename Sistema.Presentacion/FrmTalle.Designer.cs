namespace Sistema.Presentacion
{
    partial class FrmTalle
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
            this.errorIcono = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(332, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "(*) Son Obligatorios";
            // 
            // BtActualizar
            // 
            this.BtActualizar.BackColor = System.Drawing.Color.Gold;
            this.BtActualizar.Location = new System.Drawing.Point(552, 308);
            this.BtActualizar.Name = "BtActualizar";
            this.BtActualizar.Size = new System.Drawing.Size(154, 23);
            this.BtActualizar.TabIndex = 61;
            this.BtActualizar.Text = "Actualizar";
            this.BtActualizar.UseVisualStyleBackColor = false;
            this.BtActualizar.Click += new System.EventHandler(this.BtActualizar_Click);
            // 
            // BtCancelar
            // 
            this.BtCancelar.BackColor = System.Drawing.Color.SpringGreen;
            this.BtCancelar.Location = new System.Drawing.Point(749, 308);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(161, 23);
            this.BtCancelar.TabIndex = 60;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = false;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // BtInsertar
            // 
            this.BtInsertar.BackColor = System.Drawing.Color.Chocolate;
            this.BtInsertar.Location = new System.Drawing.Point(346, 308);
            this.BtInsertar.Name = "BtInsertar";
            this.BtInsertar.Size = new System.Drawing.Size(154, 23);
            this.BtInsertar.TabIndex = 59;
            this.BtInsertar.Text = "Insertar";
            this.BtInsertar.UseVisualStyleBackColor = false;
            this.BtInsertar.Click += new System.EventHandler(this.BtInsertar_Click);
            // 
            // Txtid
            // 
            this.Txtid.BackColor = System.Drawing.Color.White;
            this.Txtid.Location = new System.Drawing.Point(76, 10);
            this.Txtid.Name = "Txtid";
            this.Txtid.Size = new System.Drawing.Size(44, 20);
            this.Txtid.TabIndex = 58;
            this.Txtid.Visible = false;
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(78, 51);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(200, 20);
            this.TxtNombre.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Nombre(*)";
            // 
            // ChkSeleccionar
            // 
            this.ChkSeleccionar.AutoSize = true;
            this.ChkSeleccionar.Location = new System.Drawing.Point(35, 172);
            this.ChkSeleccionar.Margin = new System.Windows.Forms.Padding(2);
            this.ChkSeleccionar.Name = "ChkSeleccionar";
            this.ChkSeleccionar.Size = new System.Drawing.Size(82, 17);
            this.ChkSeleccionar.TabIndex = 55;
            this.ChkSeleccionar.Text = "Seleccionar";
            this.ChkSeleccionar.UseVisualStyleBackColor = true;
            this.ChkSeleccionar.CheckedChanged += new System.EventHandler(this.ChkSeleccionar_CheckedChanged);
            // 
            // DgvListado
            // 
            this.DgvListado.AllowUserToAddRows = false;
            this.DgvListado.AllowUserToDeleteRows = false;
            this.DgvListado.AllowUserToOrderColumns = true;
            this.DgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.DgvListado.Location = new System.Drawing.Point(317, 69);
            this.DgvListado.Margin = new System.Windows.Forms.Padding(2);
            this.DgvListado.Name = "DgvListado";
            this.DgvListado.ReadOnly = true;
            this.DgvListado.RowTemplate.Height = 24;
            this.DgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListado.Size = new System.Drawing.Size(525, 199);
            this.DgvListado.TabIndex = 54;
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
            this.btEliminar.Location = new System.Drawing.Point(35, 212);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(180, 23);
            this.btEliminar.TabIndex = 53;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(765, 54);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 52;
            this.lblTotal.Text = "Total";
            // 
            // errorIcono
            // 
            this.errorIcono.ContainerControl = this;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(18, 13);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 63;
            this.lblID.Text = "ID";
            this.lblID.Visible = false;
            // 
            // FrmTalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1100, 450);
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
            this.Controls.Add(this.lblID);
            this.Name = "FrmTalle";
            this.Text = "Talle";
            this.Load += new System.EventHandler(this.FrmTalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorIcono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.ErrorProvider errorIcono;
        private System.Windows.Forms.Label lblID;
    }
}