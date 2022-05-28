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
        //Metodos CRUD son: Create, Read, Update y Delete
        //Metodo Crear
        public Task<int> EmpleSave(Empleado emple)
        {
            if (emple.id != 0)
            {
                return dbase.UpdateAsync(emple); //Update
            }
            else
            {
                return dbase.InsertAsync(emple); //Insert
            }
        }
        //Read
        public Task<List<Empleado>> ObtenerListaEmple()
        {
            return dbase.Table<Empleado>().ToListAsync();
        }
        //Read v2
        public Task<Empleado> ObtenerEmple(int pid)
        {
            return dbase.Table<Empleado>()
                .Where(i => i.id == pid)
                .FirstOrDefaultAsync();
        }
        //Delete
        public Task<int> BorrarEmple(Empleado emple)
        {
            return dbase.DeleteAsync(emple);
        }
    }
}
