using Microsoft.VisualBasic.ApplicationServices;

namespace Examen_Equipo
{
    public partial class Form1 : Form
    {
        Dictionary<string, (string Password, string Role)> usuarios = new Dictionary<string, (string, string)>
        {    { "jefe", ("1234", "Jefe") },{ "empleado", ("5678", "Empleado") }};

        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrase�a = txtContrase�a.Text;

            // Validar usuario y contrase�a
            if (!usuarios.ContainsKey(txtUsuario.Text) || usuarios[txtUsuario.Text].Password != contrase�a)
            {
                string rol = usuarios[txtUsuario.Text].Role;

                // Navegar al formulario seg�n el rol
                if (rol == "Jefe")
                {
                    Menu formJefe = new Menu();
                    formJefe.Show();
                }
                else if (rol == "Empleado")
                {
                    Menu formEmpleado = new Menu();
                    formEmpleado.Show();
                }

                // Cerrar el formulario actual
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contrase�a incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtContrase�a.Clear();
            txtUsuario.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
                Application.Exit();
            //
        }
    }
}
