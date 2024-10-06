using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace study_this_framework.models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Hace que el ID sea autoincremental
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        // Clave foránea para Biblioteca
        [ForeignKey("Library")]
        public int LibraryId { get; set; } // Relación con Biblioteca
        public Loan LoanId { get; set; }

    }
}
