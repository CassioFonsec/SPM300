using SPM300.Entidades;
using SPM300.Servicos;
using System;
using System.Collections.Generic;x

namespace SPM300
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConstruirMovel.CriarMovel();

            /*List<PecaAlmoxarifado> pecasAlmoxarifado = new List<PecaAlmoxarifado>();
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

            AdicionarComponentesProdutoMovel(produtosMovel, componentesMovel);
            ListarComponentesMovelDeProdutoMovel(produtosMovel);
            Console.ReadLine();*/

            /*
            RemoverComponentesProdutoMovel(produtosMovel);
            ListarComponentesMovelDeProdutoMovel(produtosMovel);
            Console.ReadLine();
            */

            /*ListarComponentesMovel(componentesMovel);
            Console.ReadLine();

            RemoverComponentesMovel(componentesMovel);
            Console.ReadLine();

            ListarComponentesMovel(componentesMovel);
            Console.ReadLine();

            ListarComponentesMovelDeProdutoMovel(produtosMovel);
            Console.ReadLine();*/
        }

        private static void RemoverComponentesMovel(List<ComponenteMovel> list)
        {
            Console.WriteLine("RemoverComponentesMovel");
            int j = list.Count;
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine("Componente : " + list[0].Descricao + " = " + list[0].Largura);
                list.RemoveAt(0);
            }


            foreach (ComponenteMovel componenteMovel in list)
            {
                Console.WriteLine("Componente : " + componenteMovel.Descricao + " = " + componenteMovel.Largura);
            }
            Console.WriteLine("Fim ListarComponentesMovel");
        }

        private static void RemoverComponentesProdutoMovel(List<ProdutoMovel> produtosMovel)
        {
            Console.WriteLine("RemoverComponentesProdutoMovel");
            foreach (ProdutoMovel produtoMovel in produtosMovel)
            {
                produtoMovel.RemoverComponenteMovel(produtoMovel.ComponentesMovel[0]);
            }
            Console.WriteLine("Fim RemoverComponentesProdutoMovel");
        }

        private static void ListarComponentesMovelDeProdutoMovel(List<ProdutoMovel> produtosMovel)
        {
            Console.WriteLine("ListarComponentesMovelDeProdutoMovel");
            foreach (ProdutoMovel produtoMovel in produtosMovel)
            {
                Console.WriteLine("Produto Movel : " + produtoMovel.Descricao);
                foreach (ComponenteMovel compMovel in produtoMovel.ComponentesMovel)
                {
                    Console.WriteLine("Componente Móvel do Produto Móvel:" + compMovel.Descricao);
                }
            }
            Console.WriteLine("Fim ListarComponentesMovelDeProdutoMovel");
        }

        private static void AdicionarComponentesProdutoMovel(List<ProdutoMovel> produtosMovel, List<ComponenteMovel> componentesMovel)
        {
            Console.WriteLine("AdicionarComponentesProdutoMovel");
            for (int i = 0; i < produtosMovel.Count; i++)
            {
                produtosMovel[i].AdicionarComponenteMovel(componentesMovel[i]);
            }
            Console.WriteLine("Fim AdicionarComponentesProdutoMovel");
        }

        private static void ListaProdutosMovel(List<ProdutoMovel> list)
        {
            Console.WriteLine("ListaProdutosMovel");
            foreach (ProdutoMovel produtoMovel in list)
            {
                Console.WriteLine("Produto Movel : " + produtoMovel.Descricao);
            }
            Console.WriteLine("Fim ListaProdutosMovel");
        }

        private static void AdicionarProdutosMovel(List<ProdutoMovel> list)
        {
            Console.WriteLine("AdicionarProdutosMovel");
            for (int i = 0; i < 11; i++)
            {
                list.Add(new ProdutoMovel(i, "ProdutoMovel-" + i, (i + 1) * 100, (i + 1) * 20, (i + 1) * 50));
            }
            Console.WriteLine("Fim AdicionarProdutosMovel");
        }

        private static void ListarComponentesMovel(List<ComponenteMovel> list)
        {
            Console.WriteLine("ListarComponentesMovel");
            foreach (ComponenteMovel componenteMovel in list)
            {
                Console.WriteLine("Componente : " + componenteMovel.Descricao + " = " + componenteMovel.Largura);
            }
            Console.WriteLine("Fim ListarComponentesMovel");
        }

        private static void AdicionarComponentesMovel(List<ComponenteMovel> list)
        {
            Console.WriteLine("AdicionarComponentesMovel");
            for (int i = 0; i < 11; i++)
            {
                list.Add(new ComponenteMovel(i, "ComponenteMovel-" + i, (i + 1) * 10, (i + 1) * 2, (i + 1) * 5));
            }
            Console.WriteLine("Fim AdicionarComponentesMovel");
        }

        private static void AdicionarPecaAlmoxarifado(List<PecaAlmoxarifado> list)
        {
            Console.WriteLine("AdicionarPecaAlmoxarifado");
            for (int i = 0; i < 11; i++)
            {
                list.Add(new PecaAlmoxarifado(i, "PecaAlmo-" + i));
            }
            Console.WriteLine("Fim AdicionarPecaAlmoxarifado");
        }

        private static void ListarPecaAlmoxarifado(List<PecaAlmoxarifado> list)
        {
            Console.WriteLine("ListarPecaAlmoxarifadol");
            foreach (PecaAlmoxarifado pecaAlmoxarifado in list)
            {
                Console.WriteLine("Peça Almoxarifado: " + pecaAlmoxarifado.Descricao);
            }
            Console.WriteLine("Fim ListarPecaAlmoxarifadol");
        }
    }
}
