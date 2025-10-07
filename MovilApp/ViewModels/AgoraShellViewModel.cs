using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MovilApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovilApp.ViewModels
{
    public partial class AgoraShellViewModel : ObservableObject
    {
        [ObservableProperty]  
        private bool userIsLogged = false;

        public IRelayCommand LogoutCommand { get; }

        public AgoraShellViewModel()
        {
            LogoutCommand = new RelayCommand(OnLogout);
            SetLoginState(false);
        }

        public void SetLoginState(bool isLoggedIn)
        {
            if (Application.Current?.MainPage is AgoraShell shell)
            {
                if (isLoggedIn)
                    Shell.Current.FlyoutBehavior = FlyoutBehavior.Flyout;
                else
                    Shell.Current.FlyoutBehavior = FlyoutBehavior.Disabled;

                UserIsLogged = isLoggedIn;
                if (isLoggedIn)
                    Shell.Current.GoToAsync("//MainPage");  // Cambio a MainPage (pantalla de inicio)
                else
                    Shell.Current.GoToAsync("//Login");
            }

        }

        private void OnLogout()
        {
           SetLoginState(false);
        }
    }
}

