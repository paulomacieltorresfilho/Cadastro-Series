using System;

namespace Primeiro_Desafio
{
    class Program
    {
		private static RepositorioSerie repositorio = new RepositorioSerie();
        static void Main(string[] args)
        {
			string opcaoUsuario = Menu.ObterOpcaoUsuario();

			do 
			{

				switch (opcaoUsuario)
				{
					case "1":
						Menu.ListarSeries();
						break;
					case "2":
						Menu.AdicionarSerie();
						break;
					case "3":
						Menu.VisualizarSerie();
						break;
					case "4":
						Menu.AtualizarSerie();
						break;
					case "5":
						Menu.ExcluirSerie();
						break;
					case "C":
						Console.Clear();
						break;
					default:
						throw new ArgumentOutOfRangeException();
				}
				
				opcaoUsuario = Menu.ObterOpcaoUsuario();

			} while (opcaoUsuario != "X");
        
			Console.WriteLine("Até mais!");
		}
    
		public static class Menu
		{
			public static string ObterOpcaoUsuario()
			{
				Console.WriteLine();
				Console.WriteLine("1 - Listar Séries");
				Console.WriteLine("2 - Adicionar nova Série");
				Console.WriteLine("3 - Visualizar Série");
				Console.WriteLine("4 - Atualizar Série");
				Console.WriteLine("5 - Excluir Série");
				Console.WriteLine("C - Limpar Console");
				Console.WriteLine("X - Sair");

				Console.Write("Digite a opção desejada: ");

				string opcaoUsuario = Console.ReadLine();
				Console.WriteLine();

				return opcaoUsuario.ToUpper();
			}

			public static void MostraGeneros()
			{
				Console.WriteLine();
				foreach (int i in Enum.GetValues(typeof(Genero)))
				{
					Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero), i)}");
				}
				Console.WriteLine();
			}
		
			public static void ListarSeries()
			{
				repositorio.Listar();
			}
		
			public static void AdicionarSerie()
			{
				Console.WriteLine("Adicionar Série");

				MostraGeneros();

				Console.Write("Digite o número referente ao gênero da série: ");
				int genero = int.Parse(Console.ReadLine());

				Console.WriteLine();
				Console.Write("Digite o título da série: ");
				string titulo = Console.ReadLine();

				Console.WriteLine();
				Console.Write("Digite o ano de início da série: ");
				int ano = int.Parse(Console.ReadLine());

				Console.WriteLine();
				Console.Write("Digite a descrição da série: ");
				string descricao = Console.ReadLine();

				Serie serie = new Serie(id: repositorio.ProximoId(),
										titulo: titulo,
										ano: ano,
										genero: (Genero)genero,
										descricao: descricao	
				);

				repositorio.Adicionar(serie);

				Console.WriteLine("Série adicionada com sucesso!");
			}

			public static void VisualizarSerie()
			{
				Console.WriteLine("Visualizar Série\n");
				Console.Write("Digite o Id da série em questão: ");
				int index = int.Parse(Console.ReadLine());

				Console.WriteLine();
				Console.WriteLine(repositorio.RetornaPorId(index));
			}

			public static void AtualizarSerie()
			{


				Console.Write("Digite o id da série desejada: ");
				int index = int.Parse(Console.ReadLine());

				Serie serie = repositorio.RetornaPorId(index);
				string titulo = serie.getTitulo();
				int ano = serie.getAno();
				Genero genero = serie.getGenero();
				string descricao = serie.getDescricao();

				Console.WriteLine();
				Console.WriteLine(serie.ToString());
				Console.WriteLine("1 - Título");
				Console.WriteLine("2 - Ano");
				Console.WriteLine("3 - Gênero");
				Console.WriteLine("4 - Descrição\n");
				Console.Write("Digite a opção desejada: ");
				string opcao = Console.ReadLine();
				Console.WriteLine();

				switch (opcao)
				{
					case "1":
						Console.Write("Digite o título da série: ");
						titulo = Console.ReadLine();
						break;
					case "2":
						Console.Write("Digite o ano da série: ");
						ano = int.Parse(Console.ReadLine());
						break;
					case "3":
						MostraGeneros();
						Console.Write("Digite o gênero da série: ");
						genero = Enum.Parse<Genero>(Console.ReadLine());
						break;
					case "4":
						Console.Write("Digite a descrição da série: ");
						descricao = Console.ReadLine();
						break;
				}

				Serie novaSerie = new Serie(
					id: index,
					titulo: titulo,
					ano: ano,
					genero: (Genero)genero,
					descricao: descricao
				);

				repositorio.Atualizar(index, novaSerie);
				Console.WriteLine("Série atualizada com sucesso!");
			}

			public static void ExcluirSerie()
			{
				Console.WriteLine("Excluir Série\n");
				Console.Write("Digite o id da série desejada: ");
				int index = int.Parse(Console.ReadLine());

				repositorio.Excluir(index);

				Console.WriteLine("Série excluída com sucesso!");
			}
		}	
	}
}
