namespace pryIefiGarcia
{
    partial class frmProductos
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
            this.lblTituloChico = new System.Windows.Forms.Label();
            this.gbCargar = new System.Windows.Forms.GroupBox();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbConsulta = new System.Windows.Forms.GroupBox();
            this.cbProductos = new System.Windows.Forms.ComboBox();
            this.lvProductos = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFechaRegistro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdListado = new System.Windows.Forms.Button();
            this.gbCargar.SuspendLayout();
            this.gbConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloChico
            // 
            this.lblTituloChico.AutoSize = true;
            this.lblTituloChico.Font = new System.Drawing.Font("Niagara Solid", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloChico.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTituloChico.Location = new System.Drawing.Point(35, 19);
            this.lblTituloChico.Name = "lblTituloChico";
            this.lblTituloChico.Size = new System.Drawing.Size(186, 68);
            this.lblTituloChico.TabIndex = 5;
            this.lblTituloChico.Text = "Productos";
            // 
            // gbCargar
            // 
            this.gbCargar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbCargar.Controls.Add(this.cmdCargar);
            this.gbCargar.Controls.Add(this.txtNombre);
            this.gbCargar.Controls.Add(this.dtpFechaRegistro);
            this.gbCargar.Controls.Add(this.lblFecha);
            this.gbCargar.Controls.Add(this.lblNombre);
            this.gbCargar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbCargar.Location = new System.Drawing.Point(28, 120);
            this.gbCargar.Name = "gbCargar";
            this.gbCargar.Size = new System.Drawing.Size(270, 175);
            this.gbCargar.TabIndex = 6;
            this.gbCargar.TabStop = false;
            this.gbCargar.Text = "Cargar Productos";
            // 
            // cmdCargar
            // 
            this.cmdCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCargar.Location = new System.Drawing.Point(20, 108);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(229, 33);
            this.cmdCargar.TabIndex = 11;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(20, 39);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(229, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaRegistro.Location = new System.Drawing.Point(20, 78);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(229, 20);
            this.dtpFechaRegistro.TabIndex = 10;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(17, 62);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(94, 13);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "Fecha de Registro";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(17, 23);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 6;
            this.lblNombre.Text = "Nombre";
            // 
            // gbConsulta
            // 
            this.gbConsulta.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbConsulta.Controls.Add(this.cbProductos);
            this.gbConsulta.Controls.Add(this.lvProductos);
            this.gbConsulta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbConsulta.Location = new System.Drawing.Point(314, 131);
            this.gbConsulta.Name = "gbConsulta";
            this.gbConsulta.Size = new System.Drawing.Size(368, 175);
            this.gbConsulta.TabIndex = 13;
            this.gbConsulta.TabStop = false;
            this.gbConsulta.Text = "Consultar Productos";
            // 
            // cbProductos
            // 
            this.cbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Location = new System.Drawing.Point(62, 38);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(252, 21);
            this.cbProductos.TabIndex = 14;
            this.cbProductos.SelectedIndexChanged += new System.EventHandler(this.cbProductos_SelectedIndexChanged);
            // 
            // lvProductos
            // 
            this.lvProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnNombre,
            this.columnFechaRegistro});
            this.lvProductos.HideSelection = false;
            this.lvProductos.Location = new System.Drawing.Point(6, 78);
            this.lvProductos.Name = "lvProductos";
            this.lvProductos.Size = new System.Drawing.Size(356, 77);
            this.lvProductos.TabIndex = 13;
            this.lvProductos.UseCompatibleStateImageBehavior = false;
            this.lvProductos.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 25;
            // 
            // columnNombre
            // 
            this.columnNombre.Text = "Nombre";
            this.columnNombre.Width = 145;
            // 
            // columnFechaRegistro
            // 
            this.columnFechaRegistro.Text = "Fecha de Registro";
            this.columnFechaRegistro.Width = 180;
            // 
            // cmdListado
            // 
            this.cmdListado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdListado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdListado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdListado.Location = new System.Drawing.Point(224, 362);
            this.cmdListado.Name = "cmdListado";
            this.cmdListado.Size = new System.Drawing.Size(229, 33);
            this.cmdListado.TabIndex = 14;
            this.cmdListado.Text = "Listado";
            this.cmdListado.UseVisualStyleBackColor = false;
            this.cmdListado.Click += new System.EventHandler(this.cmdListado_Click);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdListado);
            this.Controls.Add(this.gbConsulta);
            this.Controls.Add(this.gbCargar);
            this.Controls.Add(this.lblTituloChico);
            this.Name = "frmProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.gbCargar.ResumeLayout(false);
            this.gbCargar.PerformLayout();
            this.gbConsulta.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloChico;
        private System.Windows.Forms.GroupBox gbCargar;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbConsulta;
        private System.Windows.Forms.ComboBox cbProductos;
        private System.Windows.Forms.ListView lvProductos;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnNombre;
        private System.Windows.Forms.ColumnHeader columnFechaRegistro;
        private System.Windows.Forms.Button cmdListado;
    }
}