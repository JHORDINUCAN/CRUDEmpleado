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
            optionsBuilder.UseMySQL("server=localhost; database=23BM; user=root; password=1234");
        }

        public DbSet<Empleado> Empleados { get; set; }
    }
}
