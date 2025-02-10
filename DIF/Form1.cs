using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIF
{
    public partial class GestionDeContactos : Form
    {
        public GestionDeContactos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Verificar si hay un elemento seleccionado en el ListBox
            if (lstContactos.SelectedItem != null)
            {
                // Eliminar el elemento seleccionado del ListBox
                lstContactos.Items.Remove(lstContactos.SelectedItem);
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un elemento para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            MessageBox.Show("EL CONTACTO HA SIDO ELIMINADO CORRECTAMENTE");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validar que todos los campos estén llenos
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtCorreo.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de agregar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del método si algún campo está vacío
            }

            // Si todos los campos están llenos, proceder con la agregación
            String nombre = txtNombre.Text;
            double telefono;

            // Intentar convertir el teléfono a un número
            if (!double.TryParse(txtTelefono.Text, out telefono))
            {
                MessageBox.Show("Por favor, ingresa un número de teléfono válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del método si el teléfono no es un número válido
            }

            String correo = txtCorreo.Text;

            // Crear el contacto
            string contacto = $"Nombre: {nombre}, Teléfono: {telefono}, Correo: {correo}";

            // Agregar el contacto a la lista
            lstContactos.Items.Add(contacto);

            // Limpiar los campos de texto después de agregar
            txtNombre.Clear();
            txtTelefono.Clear();
            txtCorreo.Clear();

            // Mostrar mensaje de confirmación
            MessageBox.Show("El contacto ha sido guardado correctamente.");
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtNombre.Text, @"^[a-zA-Z]*$"))
            {
                MessageBox.Show("El nombre solo debe contener letras.");
                txtNombre.Text = string.Empty; // Limpiar el TextBox
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtTelefono.Text, @"^[0-9]*$"))
            {
                MessageBox.Show("El teléfono solo debe contener números.");
                txtTelefono.Text = string.Empty; // Limpiar el TextBox
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lstContactos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
