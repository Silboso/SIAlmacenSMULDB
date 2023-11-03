using SIAlmacenSMULDB.ModelsSQL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SIAlmacenSMULDB.Context
{
    public class AlmacenSQLContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<CategoriaProducto> CategoriasProductos { get; set; }
        public DbSet<ProductoProveedor> ProductosProveedores { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }

        public AlmacenSQLContext(DbContextOptions<AlmacenSQLContext> options) : base(options)
        {

        }


    }
}
