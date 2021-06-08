using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
//using SQLitePCL;


namespace AppParqueo.ModeloBD
{
    public interface IConfig
    {
        string DirectorioBD { get;  }

        //ISQLitePlatform Plataforma { get; }
    }
}
