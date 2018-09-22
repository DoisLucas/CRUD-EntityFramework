using System;
using System.Linq;

namespace Entity
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var db = new BDContext())
            {

                Categoria c = new Categoria("Aventura");

                //Inserções

                //Adicionando categoria ao banco
                db.Categoria.Add(c);

                Filme f = new Filme("Interstelar", Convert.ToDateTime("27/11/2007"), c);
                Filme f1 = new Filme("Vingadores", Convert.ToDateTime("27/11/2017"), c);

                Diretor d = new Diretor("Jef Sen");
                Diretor d1 = new Diretor("Gus Lov");
                
                //Adicionando diretor ao banco
                db.Diretor.Add(d);
                db.Diretor.Add(d1);

                //Atribuindo diretor ao filme
                f.Diretor.Add(d);
                f.Diretor.Add(d1);

                f1.Diretor.Add(d1);
                f1.Diretor.Add(d);

                //Adicionando filme ao banco
                db.Filme.Add(f);
                db.Filme.Add(f1);
                             
                //Commitando operações
                db.SaveChanges();

                //Listagem

                Console.WriteLine("-- Listagem das categorias e seus filmes");
                Console.WriteLine("\nCategoria: ");

                foreach (Categoria ca in db.Categoria.Include("filmes").Include("filmes.Categoria").ToList())
                {
                    Console.WriteLine("\t" + ca);
                    Console.WriteLine("\t\tFilmes: ");

                    foreach (Filme fa in ca.filmes)
                    {
                        Console.WriteLine("\t\t\t" + fa);
                    }

                    Console.WriteLine(Environment.NewLine);

                }

                Console.WriteLine("\n-- Listagem dos Diretores e seus filmes");
                Console.WriteLine("\nDiretor: ");
        
                foreach (Diretor de in db.Diretor.Include("Filmes").Include("Filmes.Categoria").ToList())
                {
                    Console.WriteLine("\t" + de);
                    Console.WriteLine("\t\tFilmes: ");

                    foreach (Filme fe in de.Filmes)
                    {
                        Console.WriteLine("\t\t\t" + fe);
                    }

                    Console.WriteLine(Environment.NewLine);
                }



                Console.WriteLine("\n-- Listagem dos Filmes e seus diretores");
                Console.WriteLine("\nFilme: ");

                //Ordenando pelo nome do filme
                foreach (Filme f11 in db.Filme.Include("Categoria").Include("Diretor").OrderBy(fil => fil.Nome_filme).ToList())
                {
                    Console.WriteLine("\t" + f11);
                    Console.WriteLine("\tDiretores: ");

                    foreach (Diretor diretor in f11.Diretor)
                    {
                        Console.WriteLine("\t\t\t" + diretor);
                    }

                    Console.WriteLine(Environment.NewLine);
                }



            }

        }
    }
}
