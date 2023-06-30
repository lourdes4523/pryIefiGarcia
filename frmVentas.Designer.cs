namespace pryIefiGarcia
{
    partial class frmVentas
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
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblFechaVenta = new System.Windows.Forms.Label();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.dtpFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cmdListado = new System.Windows.Forms.Button();
            this.gbConsulta = new System.Windows.Forms.GroupBox();
            this.lvVentas = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnFechaVenta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbVentas = new System.Windows.Forms.ComboBox();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.cmdFiltrar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.optProducto = new System.Windows.Forms.RadioButton();
            this.optCantidad = new System.Windows.Forms.RadioButton();
            this.gbCargar.SuspendLayout();
            this.gbConsulta.SuspendLayout();
            this.gbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloChico
            // 
            this.lblTituloChico.AutoSize = true;
            this.lblTituloChico.Font = new System.Drawing.Font("Palatino Linotype", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloChico.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTituloChico.Location = new System.Drawing.Point(33, 5);
            this.lblTituloChico.Name = "lblTituloChico";
            this.lblTituloChico.Size = new System.Drawing.Size(209, 86);
            this.lblTituloChico.TabIndex = 14;
            this.lblTituloChico.Text = "Ventas";
            // 
            // gbCargar
            // 
            this.gbCargar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbCargar.Controls.Add(this.txtCantidad);
            this.gbCargar.Controls.Add(this.lblFechaVenta);
            this.gbCargar.Controls.Add(this.cmdCargar);
            this.gbCargar.Controls.Add(this.txtProducto);
            this.gbCargar.Controls.Add(this.dtpFechaVenta);
            this.gbCargar.Controls.Add(this.lblFecha);
            this.gbCargar.Controls.Add(this.lblProducto);
            this.gbCargar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbCargar.Location = new System.Drawing.Point(12, 94);
            this.gbCargar.Name = "gbCargar";
            this.gbCargar.Size = new System.Drawing.Size(270, 277);
            this.gbCargar.TabIndex = 15;
            this.gbCargar.TabStop = false;
            this.gbCargar.Text = "Cargar Ventas";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(20, 117);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(229, 20);
            this.txtCantidad.TabIndex = 13;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // lblFechaVenta
            // 
            this.lblFechaVenta.AutoSize = true;
            this.lblFechaVenta.Location = new System.Drawing.Point(17, 101);
            this.lblFechaVenta.Name = "lblFechaVenta";
            this.lblFechaVenta.Size = new System.Drawing.Size(49, 13);
            this.lblFechaVenta.TabIndex = 12;
            this.lblFechaVenta.Text = "Cantidad";
            // 
            // cmdCargar
            // 
            this.cmdCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCargar.Location = new System.Drawing.Point(20, 218);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(229, 33);
            this.cmdCargar.TabIndex = 11;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(20, 39);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(229, 20);
            this.txtProducto.TabIndex = 9;
            // 
            // dtpFechaVenta
            // 
            this.dtpFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaVenta.Location = new System.Drawing.Point(20, 78);
            this.dtpFechaVenta.Name = "dtpFechaVenta";
            this.dtpFechaVenta.Size = new System.Drawing.Size(229, 20);
            this.dtpFechaVenta.TabIndex = 10;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(17, 62);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(83, 13);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "Fecha de Venta";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(17, 23);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(50, 13);
            this.lblProducto.TabIndex = 6;
            this.lblProducto.Text = "Producto";
            // 
            // cmdListado
            // 
            this.cmdListado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmdListado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdListado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmdListado.Location = new System.Drawing.Point(173, 415);
            this.cmdListado.Name = "cmdListado";
            this.cmdListado.Size = new System.Drawing.Size(229, 33);
            this.cmdListado.TabIndex = 16;
            this.cmdListado.Text = "Listado";
            this.cmdListado.UseVisualStyleBackColor = false;
            this.cmdListado.Click += new System.EventHandler(this.cmdListado_Click);
            // 
            // gbConsulta
            // 
            this.gbConsulta.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbConsulta.Controls.Add(this.lvVentas);
            this.gbConsulta.Controls.Add(this.cbVentas);
            this.gbConsulta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbConsulta.Location = new System.Drawing.Point(288, 94);
            this.gbConsulta.Name = "gbConsulta";
            this.gbConsulta.Size = new System.Drawing.Size(368, 175);
            this.gbConsulta.TabIndex = 17;
            this.gbConsulta.TabStop = false;
            this.gbConsulta.Text = "Consultar Productos";
            // 
            // lvVentas
            // 
            this.lvVentas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnFechaVenta,
            this.columnProducto,
            this.columnCantidad});
            this.lvVentas.HideSelection = false;
            this.lvVentas.Location = new System.Drawing.Point(6, 65);
            this.lvVentas.Name = "lvVentas";
            this.lvVentas.Size = new System.Drawing.Size(356, 95);
            this.lvVentas.TabIndex = 15;
            this.lvVentas.UseCompatibleStateImageBehavior = false;
            this.lvVentas.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 25;
            // 
            // columnFechaVenta
            // 
            this.columnFechaVenta.DisplayIndex = 2;
            this.columnFechaVenta.Text = "Fecha de Venta";
            this.columnFechaVenta.Width = 180;
            // 
            // columnProducto
            // 
            this.columnProducto.DisplayIndex = 1;
            this.columnProducto.Text = "Producto";
            this.columnProducto.Width = 145;
            // 
            // columnCantidad
            // 
            this.columnCantidad.Text = "Cantidad";
            // 
            // cbVentas
            // 
            this.cbVentas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVentas.FormattingEnabled = true;
            this.cbVentas.Location = new System.Drawing.Point(62, 38);
            this.cbVentas.Name = "cbVentas";
            this.cbVentas.Size = new System.Drawing.Size(252, 21);
            this.cbVentas.TabIndex = 14;
            this.cbVentas.SelectedIndexChanged += new System.EventHandler(this.cbVentas_SelectedIndexChanged);
            // 
            // gbFiltros
            // 
            this.gbFiltros.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbFiltros.Controls.Add(this.cmdFiltrar);
            this.gbFiltros.Controls.Add(this.txtBusqueda);
            this.gbFiltros.Controls.Add(this.optProducto);
            this.gbFiltros.Controls.Add(this.optCantidad);
            this.gbFiltros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbFiltros.Location = new System.Drawing.Point(288, 275);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(368, 96);
            this.gbFiltros.TabIndex = 18;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros de Consulta";
            // 
            // cmdFiltrar
            // 
            this.cmdFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdFiltrar.Location = new System.Drawing.Point(62, 60);
            this.cmdFiltrar.Name = "cmdFiltrar";
            this.cmdFiltrar.Size = new System.Drawing.Size(229, 30);
            this.cmdFiltrar.TabIndex = 14;
            this.cmdFiltrar.Text = "Filtrar";
            this.cmdFiltrar.UseVisualStyleBackColor = true;
            this.cmdFiltrar.Click += new System.EventHandler(this.cmdFiltrar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(62, 34);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(229, 20);
            this.txtBusqueda.TabIndex = 14;
            // 
            // optProducto
            // 
            this.optProducto.AutoSize = true;
            this.optProducto.Checked = true;
            this.optProducto.Location = new System.Drawing.Point(83, 16);
            this.optProducto.Name = "optProducto";
            this.optProducto.Size = new System.Drawing.Size(68, 17);
            this.optProducto.TabIndex = 1;
            this.optProducto.TabStop = true;
            this.optProducto.Text = "Producto";
            this.optProducto.UseVisualStyleBackColor = true;
            // 
            // optCantidad
            // 
            this.optCantidad.AutoSize = true;
            this.optCantidad.Location = new System.Drawing.Point(185, 15);
            this.optCantidad.Name = "optCantidad";
            this.optCantidad.Size = new System.Drawing.Size(67, 17);
            this.optCantidad.TabIndex = 0;
            this.optCantidad.Text = "Cantidad";
            this.optCantidad.UseVisualStyleBackColor = true;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(690, 450);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.gbConsulta);
            this.Controls.Add(this.cmdListado);
            this.Controls.Add(this.gbCargar);
            this.Controls.Add(this.lblTituloChico);
            this.Name = "frmVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.gbCargar.ResumeLayout(false);
            this.gbCargar.PerformLayout();
            this.gbConsulta.ResumeLayout(false);
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloChico;
        private System.Windows.Forms.GroupBox gbCargar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblFechaVenta;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.DateTimePicker dtpFechaVenta;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Button cmdListado;
        private System.Windows.Forms.GroupBox gbConsulta;
        private System.Windows.Forms.ListView lvVentas;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnFechaVenta;
        private System.Windows.Forms.ColumnHeader columnProducto;
        private System.Windows.Forms.ColumnHeader columnCantidad;
        private System.Windows.Forms.ComboBox cbVentas;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Button cmdFiltrar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.RadioButton optProducto;
        private System.Windows.Forms.RadioButton optCantidad;
    }
}