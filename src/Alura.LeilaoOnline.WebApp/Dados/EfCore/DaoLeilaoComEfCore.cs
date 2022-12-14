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
        public DaoLeilaoComEfCore()
        {
            _context = new AppDbContext();
        }
        public IEnumerable<Leilao> Index()
        {
            var leiloes = _context.Leiloes
                .Include(l => l.Categoria);
            return leiloes;
        }
        public IEnumerable<Leilao> Pesquisa(string termo)
        {
            var leiloes = _context.Leiloes
                .Include(l => l.Categoria)
                .Where(l => string.IsNullOrWhiteSpace(termo) ||
                    l.Titulo.ToUpper().Contains(termo.ToUpper()) ||
                    l.Descricao.ToUpper().Contains(termo.ToUpper()) ||
                    l.Categoria.Descricao.ToUpper().Contains(termo.ToUpper())
                );
            return leiloes;
        }
        public IEnumerable<Categoria> BuscarCategorias()
        {
            return _context.Categorias.ToList();
        }

        public Leilao BuscarPorId(int id)
        {
            return _context.Leiloes.Find(id);
        }
        public void Inserir(Leilao model)
        {
            _context.Leiloes.Add(model);
            _context.SaveChanges();
        }
        public void Editar(Leilao model)
        {
            _context.Leiloes.Update(model);
            _context.SaveChanges();
        }
        public void Deleta(Leilao model)
        {
            _context.Leiloes.Remove(model);
            _context.SaveChanges();
        }
    }
}