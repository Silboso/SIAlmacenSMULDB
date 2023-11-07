using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SIAlmacenSMULDB.ModelsPostgres;

namespace SIAlmacenSMULDB.Context
{
    public class EmpleadosPGSQLContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        
        public DbSet<Empleado> Empleados { get; set; }

        public DbSet<TipoDeEmpleado> TiposDeEmpleado { get; set; }

        public EmpleadosPGSQLContext(DbContextOptions<EmpleadosPGSQLContext> options) : base(options)
        {

        }

    }
}
