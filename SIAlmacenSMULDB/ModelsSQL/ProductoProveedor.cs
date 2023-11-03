using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIAlmacenSMULDB.ModelsSQL
{
    /*Estructura de la tabla
     *  ProductosProveedores (
    ProductoProveedorID int NULL,
    ProductoID int NULL,
    ProveedorID int NULL,
    Estado int NULL
    );*/
    [Table("ProductosProveedores")]
    public class ProductoProveedor
    {
        [Key]
        public int ProductoProveedorID { get; set; }
        public int ProductoID { get; set; }
        public int ProveedorID { get; set; }
        public EstadoRegistro Estado { get; set; }

    }
}
