using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SIAlmacenSMULDB.ModelsSQL
{
    /* Estructura
    CategoriasProductos (
    CategoriaID int NULL,
    Nombre nvarchar(100),
    Descripcion nvarchar(max),
    Estado int NULL
    );*/
    [Table ("CategoriasProductos")]
    public class CategoriaProducto
    {
        [Key]
        public int CategoriaID { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public EstadoRegistro Estado { get; set; }
    }

    public enum EstadoRegistro
    {
        Activo = 1,
        Inactivo = 0
    }
}
