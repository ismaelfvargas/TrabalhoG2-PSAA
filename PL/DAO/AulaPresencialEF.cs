using Entities.Interfaces;
using Entities.Models;
using Entities.Models.Enums;
using Microsoft.EntityFrameworkCore;
using PL.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PL.DAO
{
    public class AulaPresencialEF : IAulaPresencialDAO
    {
        private SecondHandContext _context;

        //construtor aulas entity framework        

        public AulaPresencialEF(SecondHandContext context)
        {
            _context = context;
        }

        //recebe uma aula nova e salva no bando de dados
        public void CadastroNovaAula(AulaPresencial aulasP)
        {
            _context.Aulas.Add(aulasP);
            _context.SaveChanges();
        }
        
        public List<AulaPresencial> aulasTesteIEnumerable()
        {
            List<AulaPresencial> aula = _context.Aulas.ToList();
                                
            return aula;
        }
        
        
        //retorna um IEnumerable de categorias
        public IEnumerable<AulaPresencial> EaulasIEnumerable()
        {
            var aulas = from m in _context.Aulas
                         select m;

            return aulas;
        }

        public IQueryable<AulaPresencial> IqueryAulas()
        {
            var aulas2 = from m in _context.Aulas
                        select m;

            return aulas2;
        }

    }
}