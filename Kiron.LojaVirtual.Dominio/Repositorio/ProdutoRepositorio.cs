using Kiron.LojaVirtual.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiron.LojaVirtual.Dominio.Repositorio
{
    //Classe que irá realizar as operações no banco para a tabela Produto
    public class ProdutoRepositorio
    {
        //Variável que referencia o Entity
        private readonly EfDbContext _context = new EfDbContext();

        //Listar Produtos
        public IEnumerable<Produto> Produtos
        {
            get { return _context.Produtos; }
        }

  
    }
}
