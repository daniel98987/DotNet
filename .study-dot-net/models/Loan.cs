using System.ComponentModel.DataAnnotations.Schema;

namespace study_this_framework.models
{
    public class Loan
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateLoan { get; set; }



        // Clave foránea de Libro (relación uno a uno)
        [ForeignKey("BookId")]
        public int BookId { get; set; }
        private Book Book { get; set; }

        // Clave foránea de Usuario (relación uno a uno)
        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public User User { get; set; }
    }

}
