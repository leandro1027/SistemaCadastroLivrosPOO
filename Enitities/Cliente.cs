namespace SistemaCadastroLivrosPOO;

public class Cliente : Pessoa
{
	public string Endereco { get; set; }

	public Cliente(string Nome, string CPF, string Endereco) : base(Nome, CPF)
	{
		this.Endereco = Endereco;
	}

	public override void ObterIdentificacao()
	{
		Console.WriteLine($"Cliente: {Nome}, CPF: {CPF}, Endereço: {Endereco}");
	}
}