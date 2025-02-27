using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DIF.Forms
{
    public partial class TextBoxp3 : UserControl
    {
        public TextBoxp3()
        {
            InitializeComponent();
            textBox1.BorderStyle = BorderStyle.FixedSingle; // Asegura que el borde sea visible
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (EsEntradaValida(textBox1.Text))
            {
                textBox1.BackColor = Color.White; // Fondo normal si es válido
                textBox1.BorderStyle = BorderStyle.FixedSingle;
            }
            else
            {
                textBox1.BackColor = Color.LightCoral; // Color si hay error
                textBox1.BorderStyle = BorderStyle.Fixed3D; // Cambia el borde
            }
        }

        private bool EsEntradaValida(string texto)
        {
            return Regex.IsMatch(texto, @"^[0-9]*$"); // Solo permite números
        }
    }
}
