using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppMvcBasica.Models
{
    public class Produto : Entity
    {
        /*Em uma relação 1 para N, a chave estrangeira fica em N*/
        public Guid FornecedorId { get; set; } //Isto bastaria para um banco de dados, mas não para o EF
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        /*EF Relations, é preciso colocar um campo fornecedor (além da foreignKey) para o EF*/
        public Fornecedor Fornecedor { get; set; } //Esta é uma propriedade de navegação do EF
    }
}
