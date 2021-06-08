using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SQLite;
using SQLiteNetExtensions.Attributes;


namespace AppParqueo.ModeloBD
{
    public class ControlIngreso
    {
        [PrimaryKey, AutoIncrement]
        public int Id_control_ingreso { get; set; }
        public string Numero_placa { get; set; }
        public DateTime Hora_ingreso { get; set; }
        public DateTime Hora_Salida { get; set; }
        public bool Estado { get; set; }
        [ForeignKey(typeof(ModeloBD.Tipo_vehiculo))]
        public int Id_tipo_vehiculo { get; set; }
        [ManyToOne]
        public Tipo_vehiculo Tipo_Vehiculo { get; set; }

    }
}
