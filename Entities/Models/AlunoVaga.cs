using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Entities.Models
{
    public class AlunoVaga
    {
        [Key]
        [Display(Name = "ID do Aluno")]
        public long AlunoVagaId { get; set; }

        [Required]
        [Display(Name = "Nome do Aluno")]
        [StringLength(35, MinimumLength = 10)]
        public string NomeAluno { get; set; }

        [Required]
        [ForeignKey("AulaPresencialId")]
        public long AulaPresencialId { get; set; }
        public virtual AulaPresencial AulaPresencial { get; set; }
    }
}
