using System.Text.RegularExpressions;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            Regex validation = new Regex(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*\W).+");

            // Validaci�n de campos vac�os
            if (string.IsNullOrEmpty(txtContrasena1.Text) && string.IsNullOrEmpty(txtContrasena2.Text))
            {
                MessageBox.Show("Los campos est�n vac�os");
                return;
            }

            // Validaci�n de igualdad en cadenas
            if (!txtContrasena1.Text.Equals(txtContrasena2.Text))
            {
                MessageBox.Show("Las contrase�as no son iguales");
                return;
            }

            // Validaci�n con expresi�n regular
            if (validation.IsMatch(txtContrasena1.Text))
            {
                MessageBox.Show("La contrase�a es v�lida");

            }
            else
            {
                MessageBox.Show("La contrase�a no es v�lida");
            }
        }
    }
}