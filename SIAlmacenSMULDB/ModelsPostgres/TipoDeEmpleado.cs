using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using SIAlmacenSMULDB.ModelsSQL;

namespace SIAlmacenSMULDB.ModelsPostgres
{
    /*TABLE TiposDeEmpleados (
    identificador_categoria SERIAL PRIMARY KEY,
    nombre_categoria VARCHAR(255) NOT NULL
    estado INT Null
    );*/
    [Table("tiposdeempleados")]
    public class TipoDeEmpleado
    {
        [Key]
        public int identificador_categoria { get; set; }
        [Required]
        public string nombre_categoria { get; set; }
        public EstadoRegistro estado { get; set; }
    }
}
