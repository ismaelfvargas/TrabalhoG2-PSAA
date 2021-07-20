using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using Entities.Models;

namespace SecondHandWeb.Models
{
    public class AlunoDisplayViewModel
    {

        public long AlunoVagaId { get; set; }
        public long AulaPresencialId { get; set; }
        public string NomeAluno { get; set; }
        public SelectList AulasPresenciais { get; set; }

        public List<AlunoVaga> AlunoVaga { get; set; }

        /*
        public long AlunoVagaId { get; set; }

        public string NomeAluno { get; set; }

        public List<AulaPresencial> AulaPresencials { get; set; }

        public SelectList AulaPresencial { get; set; }

        
        [Display(Name = "ID do Aluno")]
        public long AlunoVagaId { get; set; }

        [Display(Name = "Nome do Aluno")]
        public string NomeAluno { get; set; }

        [Display(Name = "Turma")]
        public string SelectedAulaPresencial { get; set; }
        public IEnumerable<SelectListItem> AulaPresencial { get; set; }
        */

    }
}
