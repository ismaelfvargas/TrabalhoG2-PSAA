using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace Entities.Interfaces
{
    public interface IAlunoDAO
    {

        //retorna uma lista IQuerable com todos as aulas
        public List<AlunoVaga> vagasIEnumerable();

        //Salva um produto novo no banco
        public void CadastroNovaVaga(AlunoVaga vagasP);

        //retorna uma lista IQuerable com todos os alunos
        public IEnumerable<AlunoVaga> alunosVagasIEnumerable();

    }
}
