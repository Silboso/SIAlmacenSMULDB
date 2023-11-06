using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace SIAlmacenSMULDB.ModelsSQL
{
    /*Estructura de la tabla
       Productos (
    ProductoID int NULL,
    Nombre nvarchar(255),
    Descripcion nvarchar(max),
    Precio decimal NULL,
    Stock int NULL,
    CategoriaID int NULL,
    Estado int NULL,
    CodigoBarra  nvarchar(255)
    URLImagen nvarchar(255)
    );*/
    //Todos los valores son requeridos excepto el ID
    [Table("Productos")]
    public class Producto
    {
        [Key]
        public int ProductoID { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        [Required]
        public decimal Precio { get; set; }
        [Required]
        public int Stock { get; set; }
        [Required]
        public int CategoriaID { get; set; }
        [Required]
        public EstadoRegistro Estado { get; set; }
        [Required]
        [StringLength(13, MinimumLength = 13)]
        //Solo aecpta numeros y guiones
        [RegularExpression(@"^[0-9\-]*$")]
        public string CodigoBarra { get; set; }
        public string URLImagen { get; set; }
    }
}
