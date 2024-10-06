using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace study_this_framework.models
{
    public class Especialidad
    {
        [Key]  // Anotación que define la clave primaria
        public int IdEspecialidad { get; set; }
        [Column("Especialidad")]
        public required string NombreEspecialidad { get; set; }


    }
}
