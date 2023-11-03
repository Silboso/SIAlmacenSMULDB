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
     * Proveedores (
    ProveedorID int NULL,
    Nombre nvarchar(255),
    Direccion nvarchar(255),
    Telefono nvarchar(15),
    Email nvarchar(255),
    Contacto nvarchar(255),
    Estado int NULL
    );*/
    [Table("Proveedores")]
    public class Proveedor
    {
        [Key]
        public int ProveedorID { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; } = "";
        public string Email { get; set; } = "";
        public string Contacto { get; set; } = "";
        public EstadoRegistro Estado { get; set; }
    }
}
