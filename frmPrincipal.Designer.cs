namespace pryIefiGarcia
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblTituloChico = new System.Windows.Forms.Label();
            this.pbLogoGrande = new System.Windows.Forms.PictureBox();
            this.cmdVentas = new System.Windows.Forms.Button();
            this.cmdProductos = new System.Windows.Forms.Button();
            this.lblTituloGrande = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoGrande)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelMenu.Controls.Add(this.lblTituloChico);
            this.panelMenu.Controls.Add(this.pbLogoGrande);
            this.panelMenu.Controls.Add(this.cmdVentas);
            this.panelMenu.Controls.Add(this.cmdProductos);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(259, 449);
            this.panelMenu.TabIndex = 1;
            // 
            // lblTituloChico
            // 
            this.lblTituloChico.AutoSize = true;
            this.lblTituloChico.Font = new System.Drawing.Font("Parchment", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloChico.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTituloChico.Location = new System.Drawing.Point(54, 41);
            this.lblTituloChico.Name = "lblTituloChico";
            this.lblTituloChico.Size = new System.Drawing.Size(135, 68);
            this.lblTituloChico.TabIndex = 3;
            this.lblTituloChico.Text = "Ventas";
            // 
            // pbLogoGrande
            // 
            this.pbLogoGrande.Image = ((System.Drawing.Image)(resources.GetObject("pbLogoGrande.Image")));
            this.pbLogoGrande.Location = new System.Drawing.Point(66, 282);
            this.pbLogoGrande.Name = "pbLogoGrande";
            this.pbLogoGrande.Size = new System.Drawing.Size(144, 156);
            this.pbLogoGrande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoGrande.TabIndex = 1;
            this.pbLogoGrande.TabStop = false;
            // 
            // cmdVentas
            // 
            this.cmdVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmdVentas.FlatAppearance.BorderSize = 0;
            this.cmdVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdVentas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdVentas.Location = new System.Drawing.Point(2, 204);
            this.cmdVentas.Name = "cmdVentas";
            this.cmdVentas.Size = new System.Drawing.Size(263, 46);
            this.cmdVentas.TabIndex = 2;
            this.cmdVentas.Text = "Ventas";
            this.cmdVentas.UseVisualStyleBackColor = false;
            this.cmdVentas.Click += new System.EventHandler(this.cmdVentas_Click);
            // 
            // cmdProductos
            // 
            this.cmdProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cmdProductos.FlatAppearance.BorderSize = 0;
            this.cmdProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmdProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cmdProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdProductos.Location = new System.Drawing.Point(2, 144);
            this.cmdProductos.Name = "cmdProductos";
            this.cmdProductos.Size = new System.Drawing.Size(260, 46);
            this.cmdProductos.TabIndex = 1;
            this.cmdProductos.Text = "Productos";
            this.cmdProductos.UseVisualStyleBackColor = false;
            this.cmdProductos.Click += new System.EventHandler(this.cmdProductos_Click);
            // 
            // lblTituloGrande
            // 
            this.lblTituloGrande.AutoSize = true;
            this.lblTituloGrande.Font = new System.Drawing.Font("Palatino Linotype", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloGrande.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTituloGrande.Location = new System.Drawing.Point(314, 188);
            this.lblTituloGrande.Name = "lblTituloGrande";
            this.lblTituloGrande.Size = new System.Drawing.Size(313, 131);
            this.lblTituloGrande.TabIndex = 5;
            this.lblTituloGrande.Text = "Ventas";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.lblTituloGrande);
            this.Controls.Add(this.panelMenu);
            this.Name = "frmPrincipal";
            this.Text = "Gestion de ventas";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoGrande)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label lblTituloChico;
        private System.Windows.Forms.PictureBox pbLogoGrande;
        private System.Windows.Forms.Button cmdVentas;
        private System.Windows.Forms.Button cmdProductos;
        private System.Windows.Forms.Label lblTituloGrande;
    }
}