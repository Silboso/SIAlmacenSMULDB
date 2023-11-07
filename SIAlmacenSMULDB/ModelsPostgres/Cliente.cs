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
    /*CREATE TABLE Clientes (
    identificador SERIAL PRIMARY KEY,
    nombre_completo_cliente VARCHAR(255) NOT NULL,
    direccion VARCHAR(255) NOT NULL,
    telefono_contacto VARCHAR(20) NOT NULL
     estado INT Null
    );*/
    [Table("clientes")]
    public class Cliente
    {
        [Key]
        public int identificador { get; set; }
        [Required]
        public string nombre_completo_cliente { get; set; }
        [Required]
        public string direccion { get; set; }
        [Required]
        //Solo acepta numeros y los simbolos + - ()
        [RegularExpression(@"^(\+|-)?\d+$", ErrorMessage = "Solo se aceptan numeros y simbolos")]
        public string telefono_contacto { get; set; }
        public EstadoRegistro estado { get; set; }
    }
}
