using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppParqueo.ModeloBD;
using System.IO;

namespace AppParqueo
{

    

    public partial class App : Application
    {

        static LocalBD db;


        public App()
        {
            InitializeComponent();

            MainPage = new Views.HamburgerMenuPage();
        }

        public static LocalBD SQLiteBD
        {

            get 
            {
                if (db == null)
                {

                    db = new LocalBD(Path.Combine(Environment.GetFolderPath
                        (Environment.SpecialFolder.LocalApplicationData), "ParqueoBD.db3"));
                
                }
                return db;
                
            }

        
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
