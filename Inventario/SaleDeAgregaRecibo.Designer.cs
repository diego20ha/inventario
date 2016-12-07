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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSaleDeSalida));
            this.lblSalidaCafeOrigen = new System.Windows.Forms.Label();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
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
            this.lblAyuda.Location = new System.Drawing.Point(15, 273);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(327, 17);
            this.lblAyuda.TabIndex = 202;
            this.lblAyuda.Text = "Por favor seleccione el origen de la salida de café.";
            this.lblAyuda.Visible = false;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(16, 298);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(125, 38);
            this.btnVolver.TabIndex = 203;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(167, 298);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(125, 38);
            this.btnAceptar.TabIndex = 204;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // dgvOrigenes
            // 
            this.dgvOrigenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrigenes.Location = new System.Drawing.Point(16, 45);
            this.dgvOrigenes.Name = "dgvOrigenes";
            this.dgvOrigenes.Size = new System.Drawing.Size(625, 222);
            this.dgvOrigenes.TabIndex = 210;
            this.dgvOrigenes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrigenes_CellClick);
            // 
            // formSaleDeSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 348);
            this.Controls.Add(this.dgvOrigenes);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblAyuda);
            this.Controls.Add(this.lblSalidaCafeOrigen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.DataGridView dgvOrigenes;
    }
}