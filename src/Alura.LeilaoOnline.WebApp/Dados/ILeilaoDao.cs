using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Alura.LeilaoOnline.WebApp.Models;

namespace Alura.LeilaoOnline.WebApp.Dados
{
    public interface ILeilaoDao
    {
        public IEnumerable<Leilao> Index();
        public IEnumerable<Categoria> BuscarCategorias();
        public Leilao BuscarPorId(int id);
        public void Inserir(Leilao model);
        public void Editar(Leilao model);
        public void Deleta(Leilao model);
        public IEnumerable<Leilao> Pesquisa(string termo);
    }
}