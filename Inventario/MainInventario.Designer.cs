namespace Inventario
{
    partial class MainInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainInventario));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuHomeBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAddBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAddEntradaBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAddSalidaBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAddOTBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAddRolBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAddUserBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUpdateBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUpdateEntradaBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUpdateSalidaBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUpdateOTBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDeleteBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDeleteEntradaBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDeleteSalidaBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuDeleteOTBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCloseApp = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFromImage = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainFromImage)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuHomeBtn,
            this.MenuAddBtn,
            this.MenuUpdateBtn,
            this.MenuDeleteBtn,
            this.MenuCloseApp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(601, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuHomeBtn
            // 
            this.MenuHomeBtn.Name = "MenuHomeBtn";
            this.MenuHomeBtn.Size = new System.Drawing.Size(48, 20);
            this.MenuHomeBtn.Text = "Inicio";
            // 
            // MenuAddBtn
            // 
            this.MenuAddBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAddRolBtn,
            this.MenuAddUserBtn,
            this.MenuAddEntradaBtn,
            this.MenuAddSalidaBtn,
            this.MenuAddOTBtn});
            this.MenuAddBtn.Name = "MenuAddBtn";
            this.MenuAddBtn.Size = new System.Drawing.Size(61, 20);
            this.MenuAddBtn.Text = "Agregar";
            // 
            // MenuAddEntradaBtn
            // 
            this.MenuAddEntradaBtn.Name = "MenuAddEntradaBtn";
            this.MenuAddEntradaBtn.Size = new System.Drawing.Size(163, 22);
            this.MenuAddEntradaBtn.Text = "Entrada";
            this.MenuAddEntradaBtn.Click += new System.EventHandler(this.MenuAddEntradaBtn_Click);
            // 
            // MenuAddSalidaBtn
            // 
            this.MenuAddSalidaBtn.Name = "MenuAddSalidaBtn";
            this.MenuAddSalidaBtn.Size = new System.Drawing.Size(163, 22);
            this.MenuAddSalidaBtn.Text = "Salida";
            this.MenuAddSalidaBtn.Click += new System.EventHandler(this.MenuAddSalidaBtn_Click);
            // 
            // MenuAddOTBtn
            // 
            this.MenuAddOTBtn.Name = "MenuAddOTBtn";
            this.MenuAddOTBtn.Size = new System.Drawing.Size(163, 22);
            this.MenuAddOTBtn.Text = "Orden de trabajo";
            // 
            // MenuAddRolBtn
            // 
            this.MenuAddRolBtn.Name = "MenuAddRolBtn";
            this.MenuAddRolBtn.Size = new System.Drawing.Size(163, 22);
            this.MenuAddRolBtn.Text = "Rol";
            this.MenuAddRolBtn.Visible = false;
            this.MenuAddRolBtn.Click += new System.EventHandler(this.MenuAddRolBtn_Click);
            // 
            // MenuAddUserBtn
            // 
            this.MenuAddUserBtn.Name = "MenuAddUserBtn";
            this.MenuAddUserBtn.Size = new System.Drawing.Size(163, 22);
            this.MenuAddUserBtn.Text = "Usuario";
            this.MenuAddUserBtn.Visible = false;
            this.MenuAddUserBtn.Click += new System.EventHandler(this.MenuAddUserBtn_Click);
            // 
            // MenuUpdateBtn
            // 
            this.MenuUpdateBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUpdateEntradaBtn,
            this.MenuUpdateSalidaBtn,
            this.MenuUpdateOTBtn});
            this.MenuUpdateBtn.Name = "MenuUpdateBtn";
            this.MenuUpdateBtn.Size = new System.Drawing.Size(70, 20);
            this.MenuUpdateBtn.Text = "Modificar";
            // 
            // MenuUpdateEntradaBtn
            // 
            this.MenuUpdateEntradaBtn.Name = "MenuUpdateEntradaBtn";
            this.MenuUpdateEntradaBtn.Size = new System.Drawing.Size(163, 22);
            this.MenuUpdateEntradaBtn.Text = "Entrada";
            // 
            // MenuUpdateSalidaBtn
            // 
            this.MenuUpdateSalidaBtn.Name = "MenuUpdateSalidaBtn";
            this.MenuUpdateSalidaBtn.Size = new System.Drawing.Size(163, 22);
            this.MenuUpdateSalidaBtn.Text = "Salida";
            // 
            // MenuUpdateOTBtn
            // 
            this.MenuUpdateOTBtn.Name = "MenuUpdateOTBtn";
            this.MenuUpdateOTBtn.Size = new System.Drawing.Size(163, 22);
            this.MenuUpdateOTBtn.Text = "Orden de trabajo";
            // 
            // MenuDeleteBtn
            // 
            this.MenuDeleteBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuDeleteEntradaBtn,
            this.MenuDeleteSalidaBtn,
            this.MenuDeleteOTBtn});
            this.MenuDeleteBtn.Name = "MenuDeleteBtn";
            this.MenuDeleteBtn.Size = new System.Drawing.Size(62, 20);
            this.MenuDeleteBtn.Text = "Eliminar";
            // 
            // MenuDeleteEntradaBtn
            // 
            this.MenuDeleteEntradaBtn.Name = "MenuDeleteEntradaBtn";
            this.MenuDeleteEntradaBtn.Size = new System.Drawing.Size(163, 22);
            this.MenuDeleteEntradaBtn.Text = "Entrada";
            // 
            // MenuDeleteSalidaBtn
            // 
            this.MenuDeleteSalidaBtn.Name = "MenuDeleteSalidaBtn";
            this.MenuDeleteSalidaBtn.Size = new System.Drawing.Size(163, 22);
            this.MenuDeleteSalidaBtn.Text = "Salida";
            // 
            // MenuDeleteOTBtn
            // 
            this.MenuDeleteOTBtn.Name = "MenuDeleteOTBtn";
            this.MenuDeleteOTBtn.Size = new System.Drawing.Size(163, 22);
            this.MenuDeleteOTBtn.Text = "Orden de trabajo";
            // 
            // MenuCloseApp
            // 
            this.MenuCloseApp.Name = "MenuCloseApp";
            this.MenuCloseApp.Size = new System.Drawing.Size(51, 20);
            this.MenuCloseApp.Text = "Cerrar";
            this.MenuCloseApp.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // MainFromImage
            // 
            this.MainFromImage.Image = ((System.Drawing.Image)(resources.GetObject("MainFromImage.Image")));
            this.MainFromImage.Location = new System.Drawing.Point(112, 51);
            this.MainFromImage.Name = "MainFromImage";
            this.MainFromImage.Size = new System.Drawing.Size(334, 315);
            this.MainFromImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MainFromImage.TabIndex = 1;
            this.MainFromImage.TabStop = false;
            // 
            // MainInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(601, 432);
            this.Controls.Add(this.MainFromImage);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Inventario";
            this.Load += new System.EventHandler(this.MainInventario_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainFromImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuHomeBtn;
        private System.Windows.Forms.ToolStripMenuItem MenuAddBtn;
        private System.Windows.Forms.ToolStripMenuItem MenuUpdateBtn;
        private System.Windows.Forms.ToolStripMenuItem MenuDeleteBtn;
        private System.Windows.Forms.ToolStripMenuItem MenuAddEntradaBtn;
        private System.Windows.Forms.ToolStripMenuItem MenuAddSalidaBtn;
        private System.Windows.Forms.ToolStripMenuItem MenuAddOTBtn;
        private System.Windows.Forms.ToolStripMenuItem MenuUpdateEntradaBtn;
        private System.Windows.Forms.ToolStripMenuItem MenuUpdateSalidaBtn;
        private System.Windows.Forms.ToolStripMenuItem MenuUpdateOTBtn;
        private System.Windows.Forms.ToolStripMenuItem MenuDeleteEntradaBtn;
        private System.Windows.Forms.ToolStripMenuItem MenuDeleteSalidaBtn;
        private System.Windows.Forms.ToolStripMenuItem MenuDeleteOTBtn;
        private System.Windows.Forms.ToolStripMenuItem MenuAddRolBtn;
        private System.Windows.Forms.ToolStripMenuItem MenuAddUserBtn;
        private System.Windows.Forms.PictureBox MainFromImage;
        private System.Windows.Forms.ToolStripMenuItem MenuCloseApp;

    }
}