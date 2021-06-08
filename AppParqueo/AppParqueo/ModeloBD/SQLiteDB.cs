using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppParqueo.ModeloBD
{
   

   public class SQLiteDB
    {
        SQLiteAsyncConnection db;

        public SQLiteDB(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db.CreateTableAsync<Tipo_vehiculo>().Wait();
        }

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

    }
}
