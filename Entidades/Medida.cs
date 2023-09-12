using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPM300.Entidades
{
    internal struct Medida
    {
        public Medida(float largura, float altura, float profundidade) 
        {
            this.Largura = largura;
            this.Altura = altura;
            this.Profundidade = profundidade;
        }
        public float Largura { get;  private set; }
        public float Altura { get; private set;}
        public float Profundidade { get; private set; }
    }
}
