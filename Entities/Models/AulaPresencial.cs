using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class AulaPresencial
    {
        [Key]
        [Display(Name = "ID da Aula")]
        public long AulaPresencialId { get; set; }

        [Required]
        [Display(Name = "Numero da Disciplina")]
        public int CodCred { get; set; }

        [Required]
        [Display(Name = "Nome da Turma")]
        [StringLength(100, MinimumLength = 10)]
        public string Turma { get; set; }

        [Required]
        [Display(Name = "Data da Atividade")]
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }

        public virtual ICollection<AlunoVaga> AlunoVaga { get; set; }

    }
}
