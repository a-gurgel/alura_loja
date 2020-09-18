using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    class ProdutoDAOEntity : IProdutoDAO, IDisposable
    {
        private LojaContext contexo;

        public ProdutoDAOEntity()
        {
            this.contexo = new LojaContext();
        }

        public void Adicionar(Produto p)
        {
            contexo.Produtos.Add(p);
            contexo.SaveChanges();
        }

        public void Atualizar(Produto p)
        {
            contexo.Produtos.Update(p);
            contexo.SaveChanges();
        }

        public void Dispose()
        {
            contexo.Dispose();
        }

        public IList<Produto> Produtos()
        {
            return contexo.Produtos.ToList();
        }

        public void Remover(Produto p)
        {
            contexo.Produtos.Remove(p);
            contexo.SaveChanges();
        }
    }
}
