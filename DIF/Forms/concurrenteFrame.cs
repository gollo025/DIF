using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIF.Forms
{
    public partial class concurrenteFrame : Form
    {
        public concurrenteFrame()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                // Cambia este valor según el límite que desees (puedes pedirlo al usuario en un TextBox)
                int N = 500; // Ejemplo de límite
                int M = 4; // Número de hilos, puedes ajustar este valor

                // Llamamos al método adaptado y mostramos el resultado en un MessageBox
                string resultado = Concurrente.Ejecutar(N, M);
                MessageBox.Show(resultado, "Resultado del Cálculo");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

    }
}
