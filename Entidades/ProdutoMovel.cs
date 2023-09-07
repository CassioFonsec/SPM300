using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPM300.Entidades
{
    internal class ProdutoMovel : Produto
    {
        public float Largura { get; set; }
        public float Altura { get; set; }
        public float Profundidade { get; set; }
        public List<ComponenteMovel> ComponentesMovel { get; private set; } = new List<ComponenteMovel>();
        public ProdutoMovel(int id, string descricao) : base(id, descricao) { }
        public ProdutoMovel(int id, string descricao, float largura, float altura, float profundidade)
            : base(id, descricao)
        {
            Largura = largura;
            Altura = altura;
            Profundidade = profundidade;
        }

        public void AdicionarComponenteMovel(ComponenteMovel componenteMovel)
        {
            ComponentesMovel.Add(componenteMovel);
        }

        public void RemoverComponenteMovel(ComponenteMovel componenteMovel)
        {
            ComponentesMovel.Remove(componenteMovel);
        }
    
    }
}
