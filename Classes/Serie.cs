using System;

namespace Primeiro_Desafio
{
	public class Serie
	{
		private int Id;
		private string Titulo;
		private int Ano;
		private Genero Genero;
		private string Descricao;
		private bool Excluido;

		public Serie (int id, string titulo, int ano, Genero genero, string descricao)
		{
			this.Id = id;
			this.Titulo = titulo;
			this.Ano = ano;
			this.Genero = genero;
			this.Descricao = descricao;
			this.Excluido = false;
		}

		public override string ToString()
		{
			string retorno = "";
			retorno += $"Id: {this.Id}\n";
			retorno += $"Título: {this.Titulo}\n";
			retorno += $"Ano: {this.Ano}\n";
			retorno += $"Gênero: {this.Genero}\n";
			retorno += $"Descrição: {this.Descricao}\n";
			return retorno;
		}

		public void Excluir()
		{
			this.Excluido = true;
		}

		//Getters and Setters
		public int getId()
		{
			return this.Id;
		}

		public string getTitulo()
		{
			return this.Titulo;
		}

		public int getAno()
		{
			return this.Ano;
		}

		public Genero getGenero()
		{
			return this.Genero;
		}

		public string getDescricao()
		{
			return this.Descricao;
		}

		public bool getExcluido()
		{
			return this.Excluido;
		}

		public void setTitulo(string novoTitulo)
		{
			this.Titulo = novoTitulo;
		}

		public void setAno(int novoAno)
		{
			this.Ano = novoAno;
		}

		public void setGenero(Genero novoGenero)
		{
			this.Genero = novoGenero;
		}

		public void setDescricao(string novaDescricao)
		{
			this.Descricao = novaDescricao;
		}
	}
}

				

