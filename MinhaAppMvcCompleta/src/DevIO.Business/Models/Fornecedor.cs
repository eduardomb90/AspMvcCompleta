using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppMvcBasica.Models
{
    public class Fornecedor : Entity
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }
        public Endereco Endereco { get; set; }
        public bool Ativo { get; set; }

        /* EF Relations */
        // A lista de produtos não necessitaria estar aqui, mas para fins de relacionamento no EF, é necessário

        public IEnumerable<Produto> Produtos { get; set; } //Fornecedor tem uma relação de 1 para N com Produtos
    }
}
