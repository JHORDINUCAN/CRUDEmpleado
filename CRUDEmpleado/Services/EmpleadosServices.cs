using CRUDEmpleado.Context;
using CRUDEmpleado.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDEmpleado.Services
{
    public class EmpleadosServices
    {

        public void Agregar(Empleado request)
        {
            try
            {
                using (var _context = new ApplicationDbContext())
                {
                    Empleado res = new Empleado()
                    {
                        Nombre = request.Nombre,
                        Apellido = request.Apellido,
                        FechaRegistro = DateTime.Now,
                        Correo = request.Correo,
                    };
                    _context.Empleados.Add(res);
                    _context.SaveChanges();
                }

            }
            catch (Exception ex) 
            {
                throw new Exception("Sucedio un error:" + ex.Message);
            }
        }
    }
}
