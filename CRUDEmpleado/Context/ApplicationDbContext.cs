using CRUDEmpleado.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEmpleado.Context
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            //Aquí va la cadena de conexión
            optionsBuilder.UseMySQL("server=localhost; port=3306; User ID=root; database=Empleados23BM; password=12345");
        }

        public DbSet<Empleado> Empleados { get; set; }
    }
}
