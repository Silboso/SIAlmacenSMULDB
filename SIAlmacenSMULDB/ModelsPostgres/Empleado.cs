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
    /*TABLE Empleados (
    identificador SERIAL PRIMARY KEY,
    nombre_completo_empleado VARCHAR(255) NOT NULL,
    salario_diario NUMERIC(10, 2) NOT NULL,
    tipo_empleado_id INT REFERENCES TiposDeEmpleados(identificador_categoria)
    estado INT Null
);
*/
    [Table("empleados")]
    public class Empleado
    {
        [Key]
        public int identificador { get; set; }
        [Required]
        public string nombre_completo_empleado { get; set; }
        [Required]
        public decimal salario_diario { get; set; }
        [Required]
        public int tipo_empleado_id { get; set; }
        public EstadoRegistro estado { get; set; }
    }

    
}
