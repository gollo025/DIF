﻿namespace DIF.Forms
{
    partial class Practica3
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
            this.botonUserControl11 = new DIF.Forms.BotonUserControl1();
            this.SuspendLayout();
            // 
            // botonUserControl11
            // 
            this.botonUserControl11.Location = new System.Drawing.Point(67, 60);
            this.botonUserControl11.Name = "botonUserControl11";
            this.botonUserControl11.Size = new System.Drawing.Size(431, 342);
            this.botonUserControl11.TabIndex = 0;
            // 
            // Practica3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botonUserControl11);
            this.Name = "Practica3";
            this.Text = "Practica3";
            this.ResumeLayout(false);

        }

        #endregion

        private BotonUserControl1 botonUserControl11;
    }
}