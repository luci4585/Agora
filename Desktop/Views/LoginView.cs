using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Firebase.Auth;
using Firebase.Auth.Providers;

namespace Desktop.Views
{
    public partial class LoginView : Form
    {
        FirebaseAuthClient _firebaseAuthClient;
        int loginFailCount = 0;

        public LoginView()
        {
            InitializeComponent();
            SettingFirebase();
        }

        private void SettingFirebase()
        {
            var config = new FirebaseAuthConfig()
            {
                ApiKey = Service.Properties.Resources.ApiKeyFirebase,
                AuthDomain = Service.Properties.Resources.AuthDomainFirebase,
                Providers = new FirebaseAuthProvider[]
                {
                     new EmailProvider()

                }
            };
            _firebaseAuthClient = new FirebaseAuthClient(config);
        }

        private async void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                UserCredential userCredential = await _firebaseAuthClient.SignInWithEmailAndPasswordAsync(TxtEmail.Text, TxtPassword.Text);
                if (userCredential != null && !string.IsNullOrEmpty(userCredential.User.Uid))
                {
                    this.Hide();
                    var menuPrincipalView = new MenuPrincipalView();
                    menuPrincipalView.ShowDialog();
                    this.Close();
                }
            }
            catch (FirebaseAuthException ex)
            {
                MessageBox.Show("Error al iniciar sesión. Verifique sus credenciales.");
                loginFailCount++;
                if (loginFailCount >= 3)
                {
                    MessageBox.Show("Ha excedido el número máximo de intentos fallidos. La aplicación se cerrará.");
                    Application.Exit();
                }
            }

        }

        private void CheckVerContraseña_CheckedChanged(object sender, EventArgs e)
        {
            TxtPassword.PasswordChar = CheckVerContraseña.Checked ? '\0':'*';
        }
    }
}
