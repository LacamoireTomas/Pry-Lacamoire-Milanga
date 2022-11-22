namespace Pry_Lacamoire_Milanga
{
    partial class frmBar
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBar));
            this.dgvMozosyArticulos = new System.Windows.Forms.DataGridView();
            this.columnMozos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnComidas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnBebidasAlcoholicas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnBebidasSinAlcohol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPostres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdValidar = new System.Windows.Forms.Button();
            this.cmdMozodelDia = new System.Windows.Forms.Button();
            this.cmdTotal = new System.Windows.Forms.Button();
            this.mrcCargarVentas = new System.Windows.Forms.GroupBox();
            this.mrcResumen = new System.Windows.Forms.GroupBox();
            this.txtSumaTotal = new System.Windows.Forms.TextBox();
            this.lblSumaTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblMozo = new System.Windows.Forms.Label();
            this.lblPostres = new System.Windows.Forms.Label();
            this.lblBebidasSinAlcohol = new System.Windows.Forms.Label();
            this.lblBebidasAlcoholicas = new System.Windows.Forms.Label();
            this.lblComidas = new System.Windows.Forms.Label();
            this.txtPostres = new System.Windows.Forms.TextBox();
            this.txtBebidasSinAlcohol = new System.Windows.Forms.TextBox();
            this.txtBebidasAlcoholicas = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtComidas = new System.Windows.Forms.TextBox();
            this.txtMozo = new System.Windows.Forms.TextBox();
            this.cmdSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMozosyArticulos)).BeginInit();
            this.mrcCargarVentas.SuspendLayout();
            this.mrcResumen.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMozosyArticulos
            // 
            this.dgvMozosyArticulos.AllowUserToAddRows = false;
            this.dgvMozosyArticulos.AllowUserToDeleteRows = false;
            this.dgvMozosyArticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMozosyArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMozosyArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnMozos,
            this.columnComidas,
            this.columnBebidasAlcoholicas,
            this.columnBebidasSinAlcohol,
            this.columnPostres});
            this.dgvMozosyArticulos.Location = new System.Drawing.Point(19, 27);
            this.dgvMozosyArticulos.Name = "dgvMozosyArticulos";
            this.dgvMozosyArticulos.Size = new System.Drawing.Size(543, 146);
            this.dgvMozosyArticulos.TabIndex = 0;
            this.dgvMozosyArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMozosyArticulos_CellContentClick);
            this.dgvMozosyArticulos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMozosyArticulos_CellFormatting);
            this.dgvMozosyArticulos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMozosyArticulos_CellValueChanged);
            this.dgvMozosyArticulos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvMozosyArticulos_KeyPress);
            // 
            // columnMozos
            // 
            this.columnMozos.HeaderText = "Mozos";
            this.columnMozos.Name = "columnMozos";
            // 
            // columnComidas
            // 
            this.columnComidas.HeaderText = "Comidas";
            this.columnComidas.Name = "columnComidas";
            // 
            // columnBebidasAlcoholicas
            // 
            this.columnBebidasAlcoholicas.HeaderText = "Bebidas Alcohoicas";
            this.columnBebidasAlcoholicas.Name = "columnBebidasAlcoholicas";
            // 
            // columnBebidasSinAlcohol
            // 
            this.columnBebidasSinAlcohol.HeaderText = "Bebidas Sin Alcohol";
            this.columnBebidasSinAlcohol.Name = "columnBebidasSinAlcohol";
            // 
            // columnPostres
            // 
            this.columnPostres.HeaderText = "Postres";
            this.columnPostres.Name = "columnPostres";
            // 
            // cmdValidar
            // 
            this.cmdValidar.Location = new System.Drawing.Point(608, 90);
            this.cmdValidar.Name = "cmdValidar";
            this.cmdValidar.Size = new System.Drawing.Size(75, 23);
            this.cmdValidar.TabIndex = 1;
            this.cmdValidar.Text = "Validar";
            this.cmdValidar.UseVisualStyleBackColor = true;
            this.cmdValidar.Click += new System.EventHandler(this.cmdValidar_Click);
            // 
            // cmdMozodelDia
            // 
            this.cmdMozodelDia.Location = new System.Drawing.Point(19, 47);
            this.cmdMozodelDia.Name = "cmdMozodelDia";
            this.cmdMozodelDia.Size = new System.Drawing.Size(91, 23);
            this.cmdMozodelDia.TabIndex = 2;
            this.cmdMozodelDia.Text = "Mozo Del Día";
            this.cmdMozodelDia.UseVisualStyleBackColor = true;
            this.cmdMozodelDia.Click += new System.EventHandler(this.cmdMozodelDia_Click);
            // 
            // cmdTotal
            // 
            this.cmdTotal.Location = new System.Drawing.Point(19, 129);
            this.cmdTotal.Name = "cmdTotal";
            this.cmdTotal.Size = new System.Drawing.Size(91, 23);
            this.cmdTotal.TabIndex = 3;
            this.cmdTotal.Text = "Total";
            this.cmdTotal.UseVisualStyleBackColor = true;
            this.cmdTotal.Click += new System.EventHandler(this.cmdTotal_Click);
            // 
            // mrcCargarVentas
            // 
            this.mrcCargarVentas.Controls.Add(this.cmdSalir);
            this.mrcCargarVentas.Controls.Add(this.dgvMozosyArticulos);
            this.mrcCargarVentas.Controls.Add(this.cmdValidar);
            this.mrcCargarVentas.Location = new System.Drawing.Point(45, 12);
            this.mrcCargarVentas.Name = "mrcCargarVentas";
            this.mrcCargarVentas.Size = new System.Drawing.Size(702, 221);
            this.mrcCargarVentas.TabIndex = 4;
            this.mrcCargarVentas.TabStop = false;
            this.mrcCargarVentas.Text = "Cargar Ventas";
            // 
            // mrcResumen
            // 
            this.mrcResumen.Controls.Add(this.txtSumaTotal);
            this.mrcResumen.Controls.Add(this.lblSumaTotal);
            this.mrcResumen.Controls.Add(this.lblTotal);
            this.mrcResumen.Controls.Add(this.lblMozo);
            this.mrcResumen.Controls.Add(this.lblPostres);
            this.mrcResumen.Controls.Add(this.lblBebidasSinAlcohol);
            this.mrcResumen.Controls.Add(this.lblBebidasAlcoholicas);
            this.mrcResumen.Controls.Add(this.lblComidas);
            this.mrcResumen.Controls.Add(this.txtPostres);
            this.mrcResumen.Controls.Add(this.txtBebidasSinAlcohol);
            this.mrcResumen.Controls.Add(this.txtBebidasAlcoholicas);
            this.mrcResumen.Controls.Add(this.txtTotal);
            this.mrcResumen.Controls.Add(this.txtComidas);
            this.mrcResumen.Controls.Add(this.txtMozo);
            this.mrcResumen.Controls.Add(this.cmdMozodelDia);
            this.mrcResumen.Controls.Add(this.cmdTotal);
            this.mrcResumen.Location = new System.Drawing.Point(45, 239);
            this.mrcResumen.Name = "mrcResumen";
            this.mrcResumen.Size = new System.Drawing.Size(702, 208);
            this.mrcResumen.TabIndex = 5;
            this.mrcResumen.TabStop = false;
            this.mrcResumen.Text = "Resumen";
            // 
            // txtSumaTotal
            // 
            this.txtSumaTotal.Location = new System.Drawing.Point(148, 184);
            this.txtSumaTotal.Name = "txtSumaTotal";
            this.txtSumaTotal.Size = new System.Drawing.Size(100, 20);
            this.txtSumaTotal.TabIndex = 16;
            // 
            // lblSumaTotal
            // 
            this.lblSumaTotal.AutoSize = true;
            this.lblSumaTotal.Location = new System.Drawing.Point(148, 168);
            this.lblSumaTotal.Name = "lblSumaTotal";
            this.lblSumaTotal.Size = new System.Drawing.Size(61, 13);
            this.lblSumaTotal.TabIndex = 15;
            this.lblSumaTotal.Text = "Suma Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(289, 34);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Total";
            // 
            // lblMozo
            // 
            this.lblMozo.AutoSize = true;
            this.lblMozo.Location = new System.Drawing.Point(148, 34);
            this.lblMozo.Name = "lblMozo";
            this.lblMozo.Size = new System.Drawing.Size(33, 13);
            this.lblMozo.TabIndex = 13;
            this.lblMozo.Text = "Mozo";
            // 
            // lblPostres
            // 
            this.lblPostres.AutoSize = true;
            this.lblPostres.Location = new System.Drawing.Point(554, 110);
            this.lblPostres.Name = "lblPostres";
            this.lblPostres.Size = new System.Drawing.Size(47, 13);
            this.lblPostres.TabIndex = 11;
            this.lblPostres.Text = "Comidas";
            // 
            // lblBebidasSinAlcohol
            // 
            this.lblBebidasSinAlcohol.AutoSize = true;
            this.lblBebidasSinAlcohol.Location = new System.Drawing.Point(425, 110);
            this.lblBebidasSinAlcohol.Name = "lblBebidasSinAlcohol";
            this.lblBebidasSinAlcohol.Size = new System.Drawing.Size(47, 13);
            this.lblBebidasSinAlcohol.TabIndex = 12;
            this.lblBebidasSinAlcohol.Text = "Comidas";
            // 
            // lblBebidasAlcoholicas
            // 
            this.lblBebidasAlcoholicas.AutoSize = true;
            this.lblBebidasAlcoholicas.Location = new System.Drawing.Point(289, 110);
            this.lblBebidasAlcoholicas.Name = "lblBebidasAlcoholicas";
            this.lblBebidasAlcoholicas.Size = new System.Drawing.Size(47, 13);
            this.lblBebidasAlcoholicas.TabIndex = 11;
            this.lblBebidasAlcoholicas.Text = "Comidas";
            // 
            // lblComidas
            // 
            this.lblComidas.AutoSize = true;
            this.lblComidas.Location = new System.Drawing.Point(148, 110);
            this.lblComidas.Name = "lblComidas";
            this.lblComidas.Size = new System.Drawing.Size(47, 13);
            this.lblComidas.TabIndex = 10;
            this.lblComidas.Text = "Comidas";
            // 
            // txtPostres
            // 
            this.txtPostres.Location = new System.Drawing.Point(557, 129);
            this.txtPostres.Name = "txtPostres";
            this.txtPostres.Size = new System.Drawing.Size(100, 20);
            this.txtPostres.TabIndex = 9;
            // 
            // txtBebidasSinAlcohol
            // 
            this.txtBebidasSinAlcohol.Location = new System.Drawing.Point(428, 129);
            this.txtBebidasSinAlcohol.Name = "txtBebidasSinAlcohol";
            this.txtBebidasSinAlcohol.Size = new System.Drawing.Size(100, 20);
            this.txtBebidasSinAlcohol.TabIndex = 8;
            // 
            // txtBebidasAlcoholicas
            // 
            this.txtBebidasAlcoholicas.Location = new System.Drawing.Point(292, 129);
            this.txtBebidasAlcoholicas.Name = "txtBebidasAlcoholicas";
            this.txtBebidasAlcoholicas.Size = new System.Drawing.Size(100, 20);
            this.txtBebidasAlcoholicas.TabIndex = 7;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(292, 50);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 6;
            // 
            // txtComidas
            // 
            this.txtComidas.Location = new System.Drawing.Point(148, 129);
            this.txtComidas.Name = "txtComidas";
            this.txtComidas.Size = new System.Drawing.Size(100, 20);
            this.txtComidas.TabIndex = 5;
            // 
            // txtMozo
            // 
            this.txtMozo.Location = new System.Drawing.Point(148, 50);
            this.txtMozo.Name = "txtMozo";
            this.txtMozo.Size = new System.Drawing.Size(100, 20);
            this.txtMozo.TabIndex = 4;
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(608, 134);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 23);
            this.cmdSalir.TabIndex = 2;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // frmBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mrcResumen);
            this.Controls.Add(this.mrcCargarVentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BAR LA MILANGA";
            this.Load += new System.EventHandler(this.FrmBar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMozosyArticulos)).EndInit();
            this.mrcCargarVentas.ResumeLayout(false);
            this.mrcResumen.ResumeLayout(false);
            this.mrcResumen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMozosyArticulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMozos;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnComidas;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBebidasAlcoholicas;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnBebidasSinAlcohol;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPostres;
        private System.Windows.Forms.Button cmdValidar;
        private System.Windows.Forms.Button cmdMozodelDia;
        private System.Windows.Forms.Button cmdTotal;
        private System.Windows.Forms.GroupBox mrcCargarVentas;
        private System.Windows.Forms.GroupBox mrcResumen;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMozo;
        private System.Windows.Forms.Label lblPostres;
        private System.Windows.Forms.Label lblBebidasSinAlcohol;
        private System.Windows.Forms.Label lblBebidasAlcoholicas;
        private System.Windows.Forms.Label lblComidas;
        private System.Windows.Forms.TextBox txtPostres;
        private System.Windows.Forms.TextBox txtBebidasSinAlcohol;
        private System.Windows.Forms.TextBox txtBebidasAlcoholicas;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtComidas;
        private System.Windows.Forms.TextBox txtMozo;
        private System.Windows.Forms.TextBox txtSumaTotal;
        private System.Windows.Forms.Label lblSumaTotal;
        private System.Windows.Forms.Button cmdSalir;
    }
}

