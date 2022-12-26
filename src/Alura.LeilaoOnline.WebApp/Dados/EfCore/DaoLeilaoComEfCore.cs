using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alura.LeilaoOnline.WebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace Alura.LeilaoOnline.WebApp.Dados.EfCore
{
    public class DaoLeilaoComEfCore : ILeilaoDao
    {
        // CLASSE DE OPERAÇÕES E ACESSOS AOS DADOS
        AppDbContext _context;

        public DaoLeilaoComEfCore(AppDbContext context)
        {
            _context = context;
        }

        public Leilao BuscarPorId(int id)
        {
            return _context.Leiloes.Find(id);
        }

        public IEnumerable<Leilao> BuscarTodos() => _context.Leiloes.Include(l => l.Categoria);

        public void Incluir(Leilao obj)
        {
            _context.Leiloes.Add(obj);
            _context.SaveChanges();
        }

        public void Alterar(Leilao obj)
        {
            _context.Leiloes.Update(obj);
            _context.SaveChanges();
        }

        public void Excluir(Leilao leilao)
        {
            _context.Leiloes.Remove(leilao);
            _context.SaveChanges();
        }
    }
}