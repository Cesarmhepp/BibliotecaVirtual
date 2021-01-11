using BibliotecaVirtual.Adicionales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BibliotecaVirtual
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
            base.OnBackButtonPressed();
        }

        private void BtnLogin(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new MenuLateral());
        }
    }
}