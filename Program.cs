using SPM300.Entidades;
using System.Collections.Generic;

namespace SPM300
{
    internal class Program
    {
        static void Main(string[] args)
        {
 
            List<PecaAlmoxarifado> pecasAlmoxarifado = new List<PecaAlmoxarifado>();
            AdicionarPecaAlmoxarifado(pecasAlmoxarifado);
            ListarPecaAlmoxarifado(pecasAlmoxarifado);
            Console.ReadLine();

            List<ComponenteMovel> componentesMovel = new List<ComponenteMovel>();
            AdicionarComponentesMovel(componentesMovel);
            ListarComponentesMovel(componentesMovel);
            Console.ReadLine();

            List<ProdutoMovel> produtosMovel = new List<ProdutoMovel>();
            AdicionarProdutosMovel(produtosMovel);
            ListaProdutosMovel(produtosMovel);
            Console.ReadLine();

            AdicionarLista(produtosMovel,() => Xpto());//() => new ProdutoMovel(1, "-"));
            ListaProdutosMovel(produtosMovel);
            Console.ReadLine(); 
        }


        private static ProdutoMovel Xpto()
        {
            ProdutoMovel item = new ProdutoMovel(1, "aaa");
            return item;
        }

        private static void AdicionarLista<T>(List<T> list, Func<T> createInstance)
        {
            for (int i = 0; i < 11; i++)
            {
                T item = createInstance();
                list.Add(item);
            }
        }


        private static void ListaProdutosMovel(List<ProdutoMovel> list)
        {
            foreach (ProdutoMovel produtoMovel in list)
            {
                Console.WriteLine("Produto Movel : " + produtoMovel.Descricao);
            }
        }

        private static void AdicionarProdutosMovel(List<ProdutoMovel> list)
        {
            for (int i = 0; i < 11; i++)
            {
                list.Add(new ProdutoMovel(i, "ProdutoMovel-" + i, (i + 1) * 100, (i + 1) * 20, (i + 1) * 50));
            }
        }

        private static void ListarComponentesMovel(List<ComponenteMovel> list)
        {
            foreach (ComponenteMovel componenteMovel in list)
            {
                Console.WriteLine("Componente : " + componenteMovel.Descricao + " = " + componenteMovel.Largura);
            }

        }

        private static void AdicionarComponentesMovel(List<ComponenteMovel> list)
        {
            for (int i = 0; i < 11; i++)
            {
                list.Add(new ComponenteMovel(i, "ComponenteMovel-" + i,(i +1 )*10,(i + 1)*2,(i + 1)*5));
            }
        }

        private static void AdicionarPecaAlmoxarifado(List<PecaAlmoxarifado> list)
        {
            for (int i = 0; i < 11; i++)
            {
                list.Add(new PecaAlmoxarifado(i, "PecaAlmo-" + i));
            }
        }

        private static void ListarPecaAlmoxarifado(List<PecaAlmoxarifado> list)
        {
            foreach (PecaAlmoxarifado pecaAlmoxarifado in list)
            {
                Console.WriteLine("Peça Almoxarifado: " + pecaAlmoxarifado.Descricao);
            }

        }
    }
}