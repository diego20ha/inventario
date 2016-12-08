namespace Inventario
{
    partial class formAddRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAddRole));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRoleName = new System.Windows.Forms.Label();
            this.txtBoxRoleName = new System.Windows.Forms.TextBox();
            this.lblRoleTitle = new System.Windows.Forms.Label();
            this.lblEspaciosRequeridos = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 117);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblRoleName
            // 
            this.lblRoleName.AutoSize = true;
            this.lblRoleName.Location = new System.Drawing.Point(150, 67);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(54, 13);
            this.lblRoleName.TabIndex = 1;
            this.lblRoleName.Text = "Nombre: *";
            // 
            // txtBoxRoleName
            // 
            this.txtBoxRoleName.Location = new System.Drawing.Point(210, 64);
            this.txtBoxRoleName.Name = "txtBoxRoleName";
            this.txtBoxRoleName.Size = new System.Drawing.Size(155, 20);
            this.txtBoxRoleName.TabIndex = 2;
            // 
            // lblRoleTitle
            // 
            this.lblRoleTitle.AutoSize = true;
            this.lblRoleTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblRoleTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleTitle.Location = new System.Drawing.Point(146, 10);
            this.lblRoleTitle.Name = "lblRoleTitle";
            this.lblRoleTitle.Size = new System.Drawing.Size(108, 22);
            this.lblRoleTitle.TabIndex = 3;
            this.lblRoleTitle.Text = "Crear Role";
            // 
            // lblEspaciosRequeridos
            // 
            this.lblEspaciosRequeridos.AutoSize = true;
            this.lblEspaciosRequeridos.ForeColor = System.Drawing.Color.Red;
            this.lblEspaciosRequeridos.Location = new System.Drawing.Point(150, 32);
            this.lblEspaciosRequeridos.Name = "lblEspaciosRequeridos";
            this.lblEspaciosRequeridos.Size = new System.Drawing.Size(220, 13);
            this.lblEspaciosRequeridos.TabIndex = 230;
            this.lblEspaciosRequeridos.Text = "Los espacios con el símbolo * son requeridos";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(153, 99);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 231;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(292, 99);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 232;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // formAddRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 134);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblEspaciosRequeridos);
            this.Controls.Add(this.lblRoleTitle);
            this.Controls.Add(this.txtBoxRoleName);
            this.Controls.Add(this.lblRoleName);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formAddRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Role de Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.TextBox txtBoxRoleName;
        private System.Windows.Forms.Label lblRoleTitle;
        private System.Windows.Forms.Label lblEspaciosRequeridos;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;

    }
}