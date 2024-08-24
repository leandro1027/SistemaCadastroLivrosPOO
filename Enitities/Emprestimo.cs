
using System;
namespace SistemaCadastroLivrosPOO;

public class Emprestimo
{
	public Livro Livro { get; set; }
	public Cliente Cliente{ get; set; }
	public DateTime DataEmprestimo { get; set; }
	public DateTime DataDevolucao { get; set; }
	
	public Emprestimo (Livro livro, Cliente cliente)
	{
		this.Livro = livro;
		this.Cliente = cliente;
		this.DataEmprestimo = DateTime.Now;
		this.DataDevolucao = DataEmprestimo.AddDays(14);
	}
	public void ConcluirEmprestimo()
		{
			Livro.Emprestar();
			Console.WriteLine($"Emprestimo concluído para o cliente {Cliente.Nome}. Data de devolução: {DataDevolucao.ToShortDateString()}");
		}

		public void DevolverLivro()
		{
			Livro.Devolver();
			Console.WriteLine($"Livro {Livro.Titulo} devolvido pelo cliente {Cliente.Nome}");
		}
}