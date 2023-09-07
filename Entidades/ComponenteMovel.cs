using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPM300.Entidades
{
    internal class ComponenteMovel : Componente
    {
        public float Largura { get; set; }
        public float Altura { get; set; }
        public float Profundiade { get; set; }

        public ComponenteMovel(int id, string descricao, float largura, float altura, float profundiade) : base(id, descricao)
        {
            this.Largura = largura;
            this.Altura = altura;
            this.Profundiade = profundiade;
        }
    }
}
