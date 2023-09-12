using SPM300.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPM300.Servicos
{
    internal static class ConstruirMovel
    {
        static public ProdutoMovel? produtoMovel { get; set; }
        static public void CriarMovel()
        {
            Medida medida = new Medida(1200f, 1000f, 800f);

            string descricaoProduto = string.Format("Mesa de computador de {0} x {1} x {2}",
                medida.Altura, medida.Largura, medida.Profundidade);
            produtoMovel = new ProdutoMovel(1, descricaoProduto, medida);
            AdicionarTampoSuperior(produtoMovel);
            AdicionarTampoLateralDireito(produtoMovel);
            AdicionarTampoLateralEsquerdo(produtoMovel);
            AdicionarTampoFundo(produtoMovel);
        }

        static private void AdicionarTampoSuperior(ProdutoMovel produtoMovel)
        {
            produtoMovel.AdicionarComponenteMovel(new ComponenteMovel(1, "Tampo Superior",
                produtoMovel.Largura, produtoMovel.Altura, produtoMovel.Profundidade));
            
        }

        static private void AdicionarTampoLateralEsquerdo(ProdutoMovel produtoMovel)
        {
            produtoMovel.AdicionarComponenteMovel(new ComponenteMovel(1, "Tampo Lateral Esquerdo",
                produtoMovel.Largura, produtoMovel.Altura, produtoMovel.Profundidade));

        }

        static private void AdicionarTampoLateralDireito(ProdutoMovel produtoMovel)
        {
            produtoMovel.AdicionarComponenteMovel(new ComponenteMovel(1, "Tampo Lateral Direito",
                produtoMovel.Largura, produtoMovel.Altura, produtoMovel.Profundidade));

        }

        static private void AdicionarTampoFundo(ProdutoMovel produtoMovel)
        {
            produtoMovel.AdicionarComponenteMovel(new ComponenteMovel(1, "Tampo Fundo",
                produtoMovel.Largura, produtoMovel.Altura, produtoMovel.Profundidade));

        }

    }
}
