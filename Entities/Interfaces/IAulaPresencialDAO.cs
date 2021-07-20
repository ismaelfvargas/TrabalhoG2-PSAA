using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace Entities.Interfaces
{
    public interface IAulaPresencialDAO
    {
        //Salva um produto novo no banco
        public void CadastroNovaAula(AulaPresencial aulasP);

        public List<AulaPresencial> aulasTesteIEnumerable();

        //retorna uma lista IQuerable com todos os alunos
        public IEnumerable<AulaPresencial> EaulasIEnumerable();

        //recebe um id de usuario e retorna um iquery de todos as aulas
        public IQueryable<AulaPresencial> IqueryAulas();
    }
}
