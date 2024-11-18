namespace Examen_Equipo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            String usuario, password;
            usuario = txtUsuario.Text;
            password = txtContraseña.Text;
        }
    }
}
