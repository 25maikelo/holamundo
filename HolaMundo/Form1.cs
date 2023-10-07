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

            // Validación de campos vacíos
            if (string.IsNullOrEmpty(txtContrasena1.Text) && string.IsNullOrEmpty(txtContrasena2.Text))
            {
                MessageBox.Show("Los campos están vacíos");
                return;
            }

            // Validación de igualdad en cadenas
            if (!txtContrasena1.Text.Equals(txtContrasena2.Text))
            {
                MessageBox.Show("Las contraseñas no son iguales");
                return;
            }

            // Validación con expresión regular
            if (validation.IsMatch(txtContrasena1.Text))
            {
                MessageBox.Show("La contraseña es válida");

            }
            else
            {
                MessageBox.Show("La contraseña no es válida");
            }
        }
    }
}