using App6.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App6.ViewModels
{
    public class PagigaInicioViewModel : BaseViewModel
    {
        Command _goToDetalles;
        Command _logOut;

        public PagigaInicioViewModel(INavigation navigation = null) : base(navigation)
        {

        }

        public Command GoToDetallesCommand
        {
            get => _goToDetalles ?? (_goToDetalles = new Command(GoToDetallesAction));
        }

        public Command LogOutCommand
        {
            get => _logOut ?? (_logOut = new Command(() => Navigation.PopToRootAsync()));
        }
        private void GoToDetallesAction(object obj)
        {
            Navigation.PushAsync(new PaginaDetalles());
        }
    }
}
