namespace PapeleriaALONDRA
{
    partial class MainApp
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.barra_estado = new System.Windows.Forms.StatusStrip();
            this.menu_principal = new System.Windows.Forms.MenuStrip();
            this.menu_archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_cerrar = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_ventana = new System.Windows.Forms.ToolStripMenuItem();
            this.submenu_articulos = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // barra_estado
            // 
            this.barra_estado.Location = new System.Drawing.Point(0, 251);
            this.barra_estado.Name = "barra_estado";
            this.barra_estado.Size = new System.Drawing.Size(602, 22);
            this.barra_estado.TabIndex = 1;
            this.barra_estado.Text = "statusStrip1";
            // 
            // menu_principal
            // 
            this.menu_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_archivo,
            this.menu_ventana});
            this.menu_principal.Location = new System.Drawing.Point(0, 0);
            this.menu_principal.MdiWindowListItem = this.menu_ventana;
            this.menu_principal.Name = "menu_principal";
            this.menu_principal.Size = new System.Drawing.Size(602, 24);
            this.menu_principal.TabIndex = 2;
            this.menu_principal.Text = "menn";
            // 
            // menu_archivo
            // 
            this.menu_archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenu_articulos,
            this.submenu_cerrar});
            this.menu_archivo.Name = "menu_archivo";
            this.menu_archivo.Size = new System.Drawing.Size(55, 20);
            this.menu_archivo.Text = "&Archivo";
            // 
            // submenu_cerrar
            // 
            this.submenu_cerrar.Name = "submenu_cerrar";
            this.submenu_cerrar.Size = new System.Drawing.Size(152, 22);
            this.submenu_cerrar.Text = "&Cerrar";
            // 
            // menu_ventana
            // 
            this.menu_ventana.Name = "menu_ventana";
            this.menu_ventana.Size = new System.Drawing.Size(59, 20);
            this.menu_ventana.Text = "&Ventana";
            // 
            // submenu_articulos
            // 
            this.submenu_articulos.Name = "submenu_articulos";
            this.submenu_articulos.Size = new System.Drawing.Size(152, 22);
            this.submenu_articulos.Text = "A&rticulos";
            this.submenu_articulos.Click += new System.EventHandler(this.submenu_articulos_Click);
            // 
            // MainApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 273);
            this.Controls.Add(this.barra_estado);
            this.Controls.Add(this.menu_principal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu_principal;
            this.Name = "MainApp";
            this.Text = "Papelería ALONDRA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menu_principal.ResumeLayout(false);
            this.menu_principal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip barra_estado;
        private System.Windows.Forms.MenuStrip menu_principal;
        private System.Windows.Forms.ToolStripMenuItem menu_archivo;
        private System.Windows.Forms.ToolStripMenuItem submenu_cerrar;
        private System.Windows.Forms.ToolStripMenuItem menu_ventana;
        private System.Windows.Forms.ToolStripMenuItem submenu_articulos;
    }
}

