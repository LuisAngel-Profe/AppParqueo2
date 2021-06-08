using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Xamarin.Forms;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
//using AppParqueo.ModeloBD;



namespace AppParqueo.ModeloBD 
{
    //public class LocalBD : IDisposable
    public class LocalBD :IDisposable
    {
        //private SQLiteConnection connection;
        SQLiteAsyncConnection db;


        public LocalBD(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<Tipo_vehiculo>().Wait();
        }

        //public void ConLocalBD(string dbPath)
        //{
        //    db = new SQLiteAsyncConnection(dbPath);
        //    db.CreateTableAsync<Tipo_vehiculo>().Wait();
        //}

        public Task<int> InserTipoVehiculo(Tipo_vehiculo tipo_Vehiculo)
        {
            if (tipo_Vehiculo.Id_tipo_vehiculo == 0)
            {
                return db.InsertAsync(tipo_Vehiculo);
            }
            else
            {
                return null;
            }        
        }


        public void InserTipoVehiculoAs(Tipo_vehiculo tipo_Vehiculo)
        {

            db.InsertAsync(tipo_Vehiculo);

        }

        public void UpdateTipoVehiculo(Tipo_vehiculo tipo_Vehiculo)
        {

            db.UpdateAsync(tipo_Vehiculo);

        }

        public void DeleteTipoVehiculo(Tipo_vehiculo tipo_Vehiculo)
        {

            db.DeleteAsync(tipo_Vehiculo);

        }

        //public Tipo_vehiculo GetTipo_Vehiculo(int id_tipo_vehiculo)
        //{

        //    return db.Table<Tipo_vehiculo>().FirstOrDefaultAsync(c => c.Id_tipo_vehiculo == id_tipo_vehiculo);
        
        //}

        public Task< List<Tipo_vehiculo>>GetTipo_Vehiculos()
        {

            return db.Table<Tipo_vehiculo>().ToListAsync();
            //return connection.Table<Tipo_vehiculo>().OrderBy(c => c.Tipo_vehiculo1).ToList(); ordenado

        }

        public void Dispose()
        {
            
            db.CloseAsync(); //liberar la conexión
        }
    }
}
