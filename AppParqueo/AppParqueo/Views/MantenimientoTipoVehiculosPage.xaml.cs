using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppParqueo.ModeloBD;


namespace AppParqueo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MantenimientoTipoVehiculosPage : ContentPage
    {
        public MantenimientoTipoVehiculosPage()
        {
            InitializeComponent();

            nuevobtn.Clicked += Nuevobtn_Clicked;

            using (var datos = new SQLiteDB)
            {
                datosListView.ItemsSource = datos.();
            }

        }

        public async void Nuevobtn_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tipoVehiculoEntry.Text))
            {

                await DisplayAlert("Error", "Debe ingresar un tipo de vehiculo", "Aceptar");
                tipoVehiculoEntry.Focus();
                return;


            }
            else if (string.IsNullOrEmpty(PrecioEntry.Text))
            {

                await DisplayAlert("Error", "Debe ingresar un precio por hora", "Aceptar");
                PrecioEntry.Focus();
                return;

            }
            else
            {
                ModeloBD.Tipo_vehiculo tipo_Vehiculo = new ModeloBD.Tipo_vehiculo
                {
                   
                    Tipo_vehiculo1 = tipoVehiculoEntry.Text,
                    Precio = int.Parse(PrecioEntry.Text)
                    
                };

                await SQLiteDB.


                limpiar();
                await DisplayAlert("Tipo Vehiculo", "Tipo de Vehiculo creado correctamente", "Aceptar");

                //using (LocalBD datos = new LocalBD)
                //{
                //    datos.InserTipoVehiculo(tipo_Vehiculo);
                //    datosListView.ItemsSource = datos.GetTipo_Vehiculos();

                //    limpiar();
                //    await DisplayAlert("Tipo Vehiculo", "Tipo de Vehiculo creado correctamente", "Aceptar");
                //}
            }
            
        }

        public void limpiar()
        {
            tipoVehiculoEntry.Text = string.Empty;
            PrecioEntry.Text =string.Empty;
        }

       
    }
}