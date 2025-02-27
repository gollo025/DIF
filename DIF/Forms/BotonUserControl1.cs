using System;
using System.Windows.Forms;
using System.Drawing;

namespace DIF.Forms
{
    public partial class BotonUserControl1 : UserControl
    {
        public BotonUserControl1()
        {
            InitializeComponent();

            // Suscribir eventos de hover
            btnP3.MouseEnter += BtnP3_MouseEnter;
            btnP3.MouseLeave += BtnP3_MouseLeave;

            // Suscribir evento de doble clic
            btnP3.DoubleClick += BtnP3_DoubleClick;
        }

        // Cambia el color cuando el cursor entra en el botón
        private void BtnP3_MouseEnter(object sender, EventArgs e)
        {
            btnP3.BackColor = Color.LightBlue; // Puedes cambiar el color a tu preferencia
        }

        // Restaura el color original cuando el cursor sale del botón
        private void BtnP3_MouseLeave(object sender, EventArgs e)
        {
            btnP3.BackColor = SystemColors.Control;
        }

        // Evento de doble clic con confirmación
        private void BtnP3_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Estás seguro de realizar esta acción?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Acción confirmada.");
            }
        }

        private void btnP3_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
