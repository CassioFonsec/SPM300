using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPM300.Entidades
{
    internal class Produto
    {
        public int Id { get; set; } = 1;
        public string Descricao { get; set; } = string.Empty;
        public DateTime DataCadastro { get; private set; } = DateTime.Now;
           
        public Produto(int id, string descricao)
        {
            Id = id;
            Descricao = descricao;
        }
    }
}
