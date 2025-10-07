using MovilApp.ViewModels;
using MovilApp.Views.Login;

namespace MovilApp.Views;

public partial class AgoraShell : Shell
{
    public AgoraShellViewModel ViewModel => (AgoraShellViewModel)BindingContext;

    public AgoraShell()
    {
        InitializeComponent();
    }
    public void SetLoginState(bool isLoggedIn)
    {
        ViewModel.SetLoginState(isLoggedIn);
            
    }
}