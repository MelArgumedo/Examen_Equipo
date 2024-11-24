namespace Examen_Equipo
{
    public partial class Form1 : Form
    {
        Dictionary<string, (string Password, string Role)> administrador1 = new Dictionary<string, (string, string)>
        {{ "Jefe", ("1234", "Jefe") }};
        Dictionary<string, (string Password, string Role)> administrador2 = new Dictionary<string, (string, string)>
        {{ "Empleado", ("5678", "Empleado") }};
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            String usuario, password;
            usuario = txtUsuario.Text;
            password = txtContraseña.Text;

            if (administrador1.ContainsKey(usuario) && administrador1[usuario].Password == password)
            {
                string rol = administrador1[usuario].Role;

                Menu frmPrincipal = new();
                frmPrincipal.Show();
                this.Hide();
            }
            else
            {
                if (administrador2.ContainsKey(usuario) && administrador2[usuario].Password == password)
                {
                    string rol = administrador2[usuario].Role;

                    Menu2 frmPrincipal = new();
                    frmPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = string.Empty;
            txtContraseña.Text = string.Empty;

            txtUsuario.Focus();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
