using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BibliotecaVirtual.Adicionales
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuLateral : MasterDetailPage
    {
        public MenuLateral()
        {
            InitializeComponent();
            MyMenu();
        }

        public void MyMenu()
        {
            Detail = new NavigationPage(new Cuenta());
            List<Menu> menu = new List<Menu>
            {
                new Menu{Page=new Cuenta(),MenuTitle="Mi Cuenta",MenuDetail="Nombre Apellido",Icon="icon_user1.png" },
                new Menu{Page=new Fabricacion(),MenuTitle="Fabricacion",MenuDetail="Manual de usuarios de fabricacion",Icon="icon_libreria.png" },
                new Menu{Page=new Envase(),MenuTitle="Envase",MenuDetail="Manual de usuarios de Envase",Icon="icon_libreria.png" },
                new Menu{Page=new Fabricacion(),MenuTitle="POE's Generales",MenuDetail="Manual de usuarios de fabricacion",Icon="icon_libreria.png" },
                new Menu{Page=new Fabricacion(),MenuTitle="LUP's Generales",MenuDetail="Lección de un punto(LUP)",Icon="icon_libreria.png" },
                new Menu{Page=new Fabricacion(),MenuTitle="Padronizados",MenuDetail="Diagramas de trabajo padronizado",Icon="icon_libreria.png" },
                new Menu{Page=new Fabricacion(),MenuTitle="IPVH",MenuDetail="Ir, Ver-Pensar y Hacer Planes de acción",Icon="icon_libreria.png" },
                new Menu{Page=new Fabricacion(),MenuTitle="Estándares",MenuDetail="Estándares de calidad para ciertos procesos",Icon="icon_libreria.png" },
            };
            ListMenu.ItemsSource = menu;
        }

        private void ListMenu_ItemSelected(object sender,SelectedItemChangedEventArgs e)
        {
            var menu = e.SelectedItem as Menu;
            if (menu != null)
            {
                IsPresented = false;
                Detail = new NavigationPage(menu.Page);
               // DisplayAlert("ItemSelected", e.SelectedItem.ToString(), "Ok");
            }
        }

        private void Cerrar_Sesion(object sender, EventArgs e)
        {
            this.Navigation.PushModalAsync(new Login());
        }

        public class Menu 
        { 
            public string MenuTitle 
            {
                get;
                set;
            }
            public string MenuDetail
            {
                get;
                set;
            }

            public ImageSource Icon
            {
                get;
                set;
            }
            public Page Page
            {
                get;
                set;
            }

        }
    }
}