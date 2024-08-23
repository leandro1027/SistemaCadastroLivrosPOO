namespace SistemaCadastroLivrosPOO;

public abstract class Pessoa : IPessoa
{
	
	public string? Nome { get; set; }
	public string? CPF { get; set; }
	
	public Pessoa (string Nome, string CPF)
	{
		this.Nome = Nome;
		this.CPF = CPF;
	}
	public void ObterInformacoes()
	{
		
	}

}