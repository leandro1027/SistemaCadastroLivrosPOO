namespace SistemaCadastroLivrosPOO;

public class Livro
{
	public string? Titulo { get; set; }
	public string? Autor { get; set; }
	public string? ISBN { get; set; }
	public bool Disponivel { get; set; }

	public Livro(string Titulo, string Autor, string ISBN)
	{
		this.Titulo = Titulo;
		this.Autor = Autor;
		this.ISBN = ISBN;
	}

	public void Emprestar()
	{
		if (Disponivel)
		{
			Disponivel = false;
			System.Console.WriteLine($"{Titulo} foi emprestado");
		}
		else
		{
			System.Console.WriteLine($"{Titulo} não está disponivel");
		}
	}
	
	public void Devolver()
	{
		Disponivel = true;
		System.Console.WriteLine($"O livro {Titulo} foi devolvido");
	}
	
}