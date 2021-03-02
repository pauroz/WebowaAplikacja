using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebowaAplikacja.Models
{
    [Table("Notes")]
    public class ClassWebApp
    {
        [Key]
        public int NoteId { get; set; }
        [DisplayName("Nazwa")]
        [Required(ErrorMessage = "Pole nazwa jest wymagane")]
        [MaxLength(50)]
        public string Name { get; set; }
        [DisplayName("Treść")]
        [MaxLength(2000)]
        public string Tresc { get; set; }
    }
}
