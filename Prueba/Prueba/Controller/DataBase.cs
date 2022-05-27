using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Prueba.Models;
using SQLite;


namespace Prueba.Controller
{
    public class DataBase
    {
        readonly SQLiteAsyncConnection dbase;

        //Constructor de la Clase
        public DataBase(string dbpath) //Manda ubicacion
        {
            dbase = new SQLiteAsyncConnection(dbpath);

            //Creacion de tablas de base de datos
            dbase.CreateTableAsync<Empleado>();
        }

    }
}
