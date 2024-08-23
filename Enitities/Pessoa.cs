namespace SistemaCadastroLivrosPOO;

public abstract class Pessoa : IPessoa
{
	
	public string? Nome { get; set; }
	public string? CPF { get; set; }
	
	public void ObterInformacoes()
	{
		
	}

	
}