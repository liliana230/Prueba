using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Prueba.Models
{
   public class Empleado
    {
        //Trabajando con SQL
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public String nombre { get; set; }
        public String edad { get; set; }

        public String genero { get; set; }

        public string fechaingreso { get; set; }
    }
}
