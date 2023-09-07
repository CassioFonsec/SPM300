using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPM300.Entidades
{
    internal class Peca
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public Peca(int id, string descricao) 
        {
            this.Id = id;
            this.Descricao = descricao;
        }
    }
}
