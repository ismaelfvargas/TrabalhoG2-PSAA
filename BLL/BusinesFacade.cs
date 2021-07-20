using Entities.Interfaces;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using PL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BusinesFacade
    {
        private readonly IApplicationUserDAO _ApplicationUserDAO;
        private readonly IAulaPresencialDAO _AulaPresencialDAO;
        private readonly IAlunoDAO _AlunoDAO;

        //construtor busines facade


        public BusinesFacade(IApplicationUserDAO Adao, IAulaPresencialDAO aula, IAlunoDAO alun)
        {
            _ApplicationUserDAO = Adao;
            _AulaPresencialDAO = aula;
            _AlunoDAO = alun;

        }


        #region Nova aula
        public void CadNovaAula(AulaPresencial aulasP)
        {
            _AulaPresencialDAO.CadastroNovaAula(aulasP);
        }
      
      //retorna um IEnumerable de alunos
        public IEnumerable<AlunoVaga> alunosVagasIEnumerable()
        {
            return _AlunoDAO.alunosVagasIEnumerable();
        }

        //retorna um IEnumerable de aulas
        public IEnumerable<AulaPresencial> EaulasIEnumerable()
        {
            return _AulaPresencialDAO.EaulasIEnumerable();
        }

        public List<AulaPresencial> aulasTesteIEnumerable()
        {
            return _AulaPresencialDAO.aulasTesteIEnumerable();
        }

        //retorna um IEnumerable de Vagas
        public List<AlunoVaga> vagasIEnumerable()
        {
            return _AlunoDAO.vagasIEnumerable();
        }

        public void CadNovaVaga(AlunoVaga vagasP)
        {
            _AlunoDAO.CadastroNovaVaga(vagasP);
        }

        //recebe um id de usuario e retorna um iquery de todos os produtos
        //de um usuario ordenados pelo status
        public IQueryable<AulaPresencial> IqueryAulas()
        {
            return _AulaPresencialDAO.IqueryAulas();
        }

        #endregion

        #region consultas em application user

        //retorna o id de um usuario
        public String getUserID(String userName)
        {
            return _ApplicationUserDAO.getUserID(userName);
        }

        #endregion
    }
}
