using ProjetoDDDSimplificado.Domain.Entidades.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDDSimplificado.Domain.Entidades.Produtos
{
    public class Produto :Base.IEntity
    {
        public int ProdutoID { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool Disponivel { get; set; }
        public int ClienteID { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
