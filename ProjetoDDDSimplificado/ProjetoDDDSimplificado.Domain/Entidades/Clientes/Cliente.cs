using ProjetoDDDSimplificado.Domain.Entidades.Produtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDDDSimplificado.Domain.Entidades.Clientes
{
    public class Cliente : Base.IEntity
    {
        public int ClienteID { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public virtual IEnumerable<Produto> Produtos { get; set; }

        public bool ClienteEspecial(Cliente cliente)
        {
            return cliente.Ativo && DateTime.Now.Year - cliente.DataCadastro.Year >= 5;
        }
    }
}
