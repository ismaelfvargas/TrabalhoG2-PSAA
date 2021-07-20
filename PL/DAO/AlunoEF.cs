using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Interfaces;
using PL.Context;
using Entities.Models;

namespace PL.DAO
{
    public class AlunoEF : IAlunoDAO
    {
        private SecondHandContext _context;

        //construtor aulas entity framework        

        public AlunoEF(SecondHandContext context)
        {
            _context = context;
        }

        public List<AlunoVaga> vagasIEnumerable()
        {
            List<AlunoVaga> aula = _context.Alunos.ToList();

            return aula;
        }

        //recebe um produto novo e salva no bando de dados
        public void CadastroNovaVaga(AlunoVaga vagasP)
        {
            _context.Alunos.Add(vagasP);
            _context.SaveChanges();
        }

        //retorna um IEnumerable de categorias
        public IEnumerable<AlunoVaga> alunosVagasIEnumerable()
        {
            var aulas = from m in _context.Alunos
                        select m;

            return aulas;
        }
    }
}
