namespace DIF.Forms
{
    partial class BotonUserControl1
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnP3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnP3
            // 
            this.btnP3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnP3.Location = new System.Drawing.Point(0, 0);
            this.btnP3.Name = "btnP3";
            this.btnP3.Size = new System.Drawing.Size(458, 390);
            this.btnP3.TabIndex = 0;
            this.btnP3.Text = "PASA EL PUNTERO SOBRE MI";
            this.btnP3.UseVisualStyleBackColor = true;
            this.btnP3.Click += new System.EventHandler(this.BtnP3_DoubleClick);
            this.btnP3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnP3_MouseClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnP3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 390);
            this.panel1.TabIndex = 1;
            // 
            // BotonUserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "BotonUserControl1";
            this.Size = new System.Drawing.Size(458, 390);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnP3;
        private System.Windows.Forms.Panel panel1;
    }
}
