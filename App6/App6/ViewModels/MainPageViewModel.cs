using App6.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App6.ViewModels
{
    class MainPageViewModel : BaseViewModel 
    {
        private string _nombreUsuario;
        private string _password;
        private bool _isErrorLogin;
        private Command _loginCommand;
    

    public MainPageViewModel(INavigation navigation) : base(navigation)
    {

    }

    public string Nombre
    {
        get => _nombreUsuario;
        set
        {
            _nombreUsuario = value;
            OnPropertyChanged();


        }
    }

    public string Contrasena
    {
        get => _password;
        set
        {
            _password = value;
            OnPropertyChanged();


        }
    }

    public Command LoginCommand
    {
        get => _loginCommand ?? (_loginCommand = new Command(GoToViewTwoAction));
    }

    public bool IsErrorLogin
    {
        get => _isErrorLogin;
        set
        {
            _isErrorLogin = value;

            OnPropertyChanged();
        }
    }

    private void GoToViewTwoAction()
    {
        IsErrorLogin = !(Nombre == "Marco" && Contrasena == "Hola");
        if (!IsErrorLogin)
        {
            Nombre = String.Empty;
            Contrasena = String.Empty;
            Navigation.PushAsync(new PaginaInicio());
        }
    }
    }
}
