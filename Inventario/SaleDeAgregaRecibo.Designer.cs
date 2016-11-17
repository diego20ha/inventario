namespace Inventario
{
    partial class formSaleDeSalida
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
            this.lblSalidaCafeOrigen = new System.Windows.Forms.Label();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblElID = new System.Windows.Forms.Label();
            this.lblEspaciosRequeridos = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvOrigenes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrigenes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSalidaCafeOrigen
            // 
            this.lblSalidaCafeOrigen.AutoSize = true;
            this.lblSalidaCafeOrigen.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalidaCafeOrigen.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblSalidaCafeOrigen.Location = new System.Drawing.Point(12, 20);
            this.lblSalidaCafeOrigen.Name = "lblSalidaCafeOrigen";
            this.lblSalidaCafeOrigen.Size = new System.Drawing.Size(193, 22);
            this.lblSalidaCafeOrigen.TabIndex = 201;
            this.lblSalidaCafeOrigen.Text = "Salida Café - Origen";
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyuda.ForeColor = System.Drawing.Color.Red;
            this.lblAyuda.Location = new System.Drawing.Point(13, 42);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(267, 17);
            this.lblAyuda.TabIndex = 202;
            this.lblAyuda.Text = "Seleccione el origen de la salida de café.";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(67, 298);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(125, 38);
            this.btnVolver.TabIndex = 203;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(314, 298);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(125, 38);
            this.btnAceptar.TabIndex = 204;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(67, 62);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbTipo.TabIndex = 205;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(14, 65);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(38, 13);
            this.lblTipo.TabIndex = 206;
            this.lblTipo.Text = "Tipo: *";
            // 
            // lblElID
            // 
            this.lblElID.AutoSize = true;
            this.lblElID.Location = new System.Drawing.Point(214, 65);
            this.lblElID.Name = "lblElID";
            this.lblElID.Size = new System.Drawing.Size(54, 13);
            this.lblElID.TabIndex = 207;
            this.lblElID.Text = "Número: *";
            // 
            // lblEspaciosRequeridos
            // 
            this.lblEspaciosRequeridos.AutoSize = true;
            this.lblEspaciosRequeridos.ForeColor = System.Drawing.Color.Red;
            this.lblEspaciosRequeridos.Location = new System.Drawing.Point(13, 86);
            this.lblEspaciosRequeridos.Name = "lblEspaciosRequeridos";
            this.lblEspaciosRequeridos.Size = new System.Drawing.Size(268, 13);
            this.lblEspaciosRequeridos.TabIndex = 208;
            this.lblEspaciosRequeridos.Text = "Los espacios con el símbolo * son espacios requeridos.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(274, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(114, 20);
            this.textBox1.TabIndex = 209;
            // 
            // dgvOrigenes
            // 
            this.dgvOrigenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrigenes.Location = new System.Drawing.Point(16, 117);
            this.dgvOrigenes.Name = "dgvOrigenes";
            this.dgvOrigenes.Size = new System.Drawing.Size(625, 150);
            this.dgvOrigenes.TabIndex = 210;
            this.dgvOrigenes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrigenes_CellClick);
            // 
            // formSaleDeSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 348);
            this.Controls.Add(this.dgvOrigenes);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblEspaciosRequeridos);
            this.Controls.Add(this.lblElID);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblAyuda);
            this.Controls.Add(this.lblSalidaCafeOrigen);
            this.Name = "formSaleDeSalida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sale De";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrigenes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalidaCafeOrigen;
        private System.Windows.Forms.Label lblAyuda;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblElID;
        private System.Windows.Forms.Label lblEspaciosRequeridos;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvOrigenes;
    }
}