namespace pryIefiGarcia
{
    partial class frmListado
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
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.lblInstrucciones = new System.Windows.Forms.Label();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.cmdVerTodo = new System.Windows.Forms.Button();
            this.cmdFiltrar = new System.Windows.Forms.Button();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.optProducto = new System.Windows.Forms.RadioButton();
            this.optCantidad = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.gbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloChico
            // 
            this.lblTituloChico.AutoSize = true;
            this.lblTituloChico.Font = new System.Drawing.Font("Niagara Solid", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloChico.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTituloChico.Location = new System.Drawing.Point(12, 9);
            this.lblTituloChico.Name = "lblTituloChico";
            this.lblTituloChico.Size = new System.Drawing.Size(142, 68);
            this.lblTituloChico.TabIndex = 6;
            this.lblTituloChico.Text = "Listado";
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(12, 80);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.ReadOnly = true;
            this.dgvListado.Size = new System.Drawing.Size(700, 235);
            this.dgvListado.TabIndex = 7;
            this.dgvListado.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListado_RowHeaderMouseDoubleClickdgvListado_RowHeaderMouseDoubleClick);
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.AutoSize = true;
            this.lblInstrucciones.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblInstrucciones.ForeColor = System.Drawing.SystemColors.Control;
            this.lblInstrucciones.Location = new System.Drawing.Point(9, 327);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(292, 13);
            this.lblInstrucciones.TabIndex = 17;
            this.lblInstrucciones.Text = "*hacer click en la cabecera de la tabla para mas informacion";
            this.lblInstrucciones.Visible = false;
            // 
            // gbFiltros
            // 
            this.gbFiltros.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbFiltros.Controls.Add(this.cmdVerTodo);
            this.gbFiltros.Controls.Add(this.cmdFiltrar);
            this.gbFiltros.Controls.Add(this.txtBusqueda);
            this.gbFiltros.Controls.Add(this.optProducto);
            this.gbFiltros.Controls.Add(this.optCantidad);
            this.gbFiltros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbFiltros.Location = new System.Drawing.Point(68, 343);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(368, 96);
            this.gbFiltros.TabIndex = 19;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros de Consulta";
            this.gbFiltros.Visible = false;
            // 
            // cmdVerTodo
            // 
            this.cmdVerTodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdVerTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdVerTodo.Location = new System.Drawing.Point(180, 60);
            this.cmdVerTodo.Name = "cmdVerTodo";
            this.cmdVerTodo.Size = new System.Drawing.Size(118, 30);
            this.cmdVerTodo.TabIndex = 15;
            this.cmdVerTodo.Text = "Ver Todo";
            this.cmdVerTodo.UseVisualStyleBackColor = true;
            this.cmdVerTodo.Click += new System.EventHandler(this.cmdVerTodo_Click);
            // 
            // cmdFiltrar
            // 
            this.cmdFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdFiltrar.Location = new System.Drawing.Point(56, 60);
            this.cmdFiltrar.Name = "cmdFiltrar";
            this.cmdFiltrar.Size = new System.Drawing.Size(118, 30);
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
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.lblInstrucciones);
            this.Controls.Add(this.dgvListado);
            this.Controls.Add(this.lblTituloChico);
            this.Name = "frmListado";
            this.Text = "Listado";
            this.Load += new System.EventHandler(this.frmListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloChico;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Label lblInstrucciones;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Button cmdVerTodo;
        private System.Windows.Forms.Button cmdFiltrar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.RadioButton optProducto;
        private System.Windows.Forms.RadioButton optCantidad;
    }
}