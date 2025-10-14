using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Firebase.Auth;
using Firebase.Auth.Providers;
using MovilApp.Views;
using Service.Enums;
using Service.Models;
using Service.Services;
using System.Net.Http.Headers;

namespace MovilApp.ViewModels.Login
{
    public partial class SignInViewModel : ObservableObject
    {
        private readonly FirebaseAuthClient _clientAuth;
        GenericService<Usuario> _usuarioService = new();
        private readonly string FirebaseApiKey;
        private readonly string RequestUri;

        public IRelayCommand RegistrarseCommand { get; }
        public IRelayCommand VolverCommand { get; }

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(RegistrarseCommand))]
        private string nombre;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(RegistrarseCommand))]
        private string lastnombre;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(RegistrarseCommand))]
        private string dni;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(RegistrarseCommand))]
        private string email;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(RegistrarseCommand))]
        private string password;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(RegistrarseCommand))]
        private string verifyPassword;

        public SignInViewModel()
        {
            FirebaseApiKey = Service.Properties.Resources.ApiKeyFirebase;
            RequestUri = "https://identitytoolkit.googleapis.com/v1/accounts:sendOobCode?key=" + FirebaseApiKey;
            RegistrarseCommand = new RelayCommand(Registrarse, PermitirRegistrarse);
            VolverCommand = new AsyncRelayCommand(Volver);
            _clientAuth = new FirebaseAuthClient(new FirebaseAuthConfig()
            {
                ApiKey = FirebaseApiKey,
                AuthDomain = Service.Properties.Resources.AuthDomainFirebase,
                Providers = new Firebase.Auth.Providers.FirebaseAuthProvider[]
                {
                        new EmailProvider()
                }
            });
        }

        private bool PermitirRegistrarse()
        {
            return !string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(verifyPassword);
        }

        private async Task Volver()
        {
            if (Application.Current?.MainPage is AgoraShell shell)
            {
               await shell.GoToAsync($"//Login");
            }
        }

        private async void Registrarse()
        {
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(verifyPassword))
            {
                await Application.Current.MainPage.DisplayAlert("Registrarse", "Por favor complete todos los campos", "Ok");
                return;
            }
            if (password == verifyPassword)
            {
                try
                {
                    var fullname = nombre + " " + lastnombre;
                    var user = await _clientAuth.CreateUserWithEmailAndPasswordAsync(email, password, fullname);
                    var nuevoUsuario = new Usuario
                    {
                        Nombre = nombre,
                        Apellido = lastnombre,
                        Dni = dni,
                        Email = email,
                        TipoUsuario = TipoUsuarioEnum.Asistente,
                        IsDeleted = false,
                        DeleteDate = DateTime.Parse("1900-01-01")
                    };
                    var usuarioCreado = await _usuarioService.AddAsync(nuevoUsuario);
                    await SendVerificationEmailAsync(user.User.GetIdTokenAsync().Result);
                    await Application.Current.MainPage.DisplayAlert("Registrarse", "Cuenta creada!", "Ok");
                    if (Application.Current?.MainPage is AgoraShell shell)
                    {
                        await shell.GoToAsync($"//Login");
                    }
                }
                catch (FirebaseAuthException error) // Use alias here 
                {
                    await Application.Current.MainPage.DisplayAlert("Registrarse", "Ocurrió un problema:" + error.Reason, "Ok");

                }
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Registrarse", "Las contraseñas ingresadas no coinciden", "Ok");
            }
        }

        public async Task SendVerificationEmailAsync(string idToken)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var content = new StringContent("{\"requestType\":\"VERIFY_EMAIL\",\"idToken\":\"" + idToken + "\"}");
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var response = await client.PostAsync(RequestUri, content);
                response.EnsureSuccessStatusCode();
            }
        }
    }
}
