using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SQLite;

namespace AppParqueo.ModeloBD
{
    public class Tipo_vehiculo
    {

        [PrimaryKey, AutoIncrement]
        public int Id_tipo_vehiculo { get; set; }
        public string Tipo_vehiculo1 { get; set; }
        public int Precio { get; set; }

        public override string ToString()
        {
            //return base.ToString();
            return string.Format("{0} {1} {2}", Id_tipo_vehiculo, Tipo_vehiculo1, Precio);
        }

    }
}
