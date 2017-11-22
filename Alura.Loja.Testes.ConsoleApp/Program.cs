using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CrudComAdoNet();

        }

        private static void CrudComAdoNet()
        {
            //Produto p = new Produto
            //{
            //    Id = 1,
            //    Nome = "ES6",
            //    Categoria = "Livros",
            //    Preco = 65.50
            //};

            using (var repo = new ProdutoDAO())
            {
                //CADASTRAR
                //Produto livro = new Produto
                //{
                //    Nome = "Livro de testes 1",
                //    Categoria = "Categoria de teste 1",
                //    Preco = 00,
                //};
                //repo.Adicionar(livro);
                //Console.WriteLine("Sucesso no cadastro!");


                // ALTERAR
                //Produto livro = new Produto
                //{
                //    Id = 1,
                //    Nome = "Livro de testes 1",
                //    Categoria = "Categoria de teste 1",
                //    Preco = 00,
                //};
                //repo.Alterar(livro);
                //Console.WriteLine("Sucesso na alteração!");


                // BUSCA
                //foreach (Produto livro in repo.Produtos())
                //{
                //    Console.WriteLine("Titulo: " + livro.Nome + ", Categoria: " + livro.Categoria + ", Preço: " + livro.Preco);
                //}


                // REMOVER
                //Produto livro = new Produto
                //{
                //    Id = 3,
                //    Nome = "Livro de testes 1",
                //    Categoria = "Categoria de teste 1",
                //    Preco = 00,
                //};
                //repo.Remover(livro);
                //Console.WriteLine("Sucesso na exclusão!");

                Console.ReadKey();
            }
        }
    }
}
