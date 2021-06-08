using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
//using SQLite.Net.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;



//[assembly: Dependency(typeof(AppParqueo.Droid.Config))]

namespace AppParqueo.Droid
{
    //class Config: ModeloBD.IConfig
    //{

    //    private string directorioBD;
    //    private ISQLitePlatform plataforma;

    //    public string DirectorioBD
    //    {
    //        get 
    //        {

    //            if (string.IsNullOrEmpty(directorioBD))
    //            {

    //                directorioBD = System.Environment.GetFolderPath(
    //                    System.Environment.SpecialFolder.Personal);
                
    //            }
    //            return directorioBD;
                
    //        }
    //    }

    //    public ISQLitePlatform Plataforma
    //    {
    //        get 
    //        {
    //            if (plataforma == null)
    //            {
    //                plataforma = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
    //            }
    //            return plataforma;
    //        }
    //    }

    //}
}