using System;
using System.Collections.Generic;

using Xamarin.Forms;


namespace AppParqueo.Views
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HamburgerMenuPage : MasterDetailPage
    {
        public HamburgerMenuPage()
        {
            InitializeComponent();
            Init();
        }

        [Obsolete]
        void Init()
        {
            List<Menu> menu = new List<Menu>()
            {
                new Menu{ Page= new HomePage(), MenuTitle = "Inicio", MenuDetails =""},
                new Menu{ Page= new SalidaPage(), MenuTitle = "Salida de Vehiculo", MenuDetails =""},
                new Menu{ Page= new MantenimientoTipoVehiculosPage(), MenuTitle = "Mantenimiento Tipo Vehiculo", MenuDetails =""}
            };

            ListMenu.ItemsSource = menu;

            Device.OnPlatform(Android: () =>
            {
                ListMenu.Margin = new Thickness(0, 21, 0, 0);
            });

            Detail = new NavigationPage(new HomePage());
        
        }

        void ListMenu_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {

            var menu = e.SelectedItem as Menu;

            if (menu != null)
            {
                IsPresented = false;
                Detail = new NavigationPage(menu.Page);

                //if (menu.MenuTitle.Equals("Inicio"))
                //{
                //    IsPresented = false;
                //    Detail = new NavigationPage(new HomePage());

                //}
                //else if (menu.MenuTitle.Equals("Salida de Vehiculo"))
                //{
                //    IsPresented = false;
                //    Detail = new NavigationPage(new SalidaPage());

                //}
                //else if (menu.MenuTitle.Equals("Mantenimiento Tipo Vehiculo"))
                //{
                //    IsPresented = false;
                //    Detail = new NavigationPage(new MantenimientoTipoVehiculosPage());

                //}

            }
        }
    

        public class Menu
        { 
        
            public string MenuTitle { get; set; }

            public string MenuDetails { get; set; }

            public Page Page { get; set; }
        }
    }
}