namespace BugTracker
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnOcultarMostrarContrasenia_Click(object sender, EventArgs e)
        {
            OcultarMostrarContrasenia();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar un Usuario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtContrasenia.Text == String.Empty)
            {
                MessageBox.Show("Debe ingresar una Contraseña", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Usted a Ingresado al Sistema", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro que quiere salir del Sitema?", "Consulta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }



        private void OcultarMostrarContrasenia()
        {
            if (txtContrasenia.PasswordChar == '*')
            { 
                txtContrasenia.PasswordChar = '\0';
                this.btnOcultarMostrarContrasenia.BackgroundImage = global::BugTracker.Properties.Resources.ocultar;
            }
            else if (txtContrasenia.PasswordChar == '\0')
            { 
                txtContrasenia.PasswordChar = '*';
                this.btnOcultarMostrarContrasenia.BackgroundImage = global::BugTracker.Properties.Resources.mostrar;
            }
        } 
    }
}