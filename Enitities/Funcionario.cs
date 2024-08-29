namespace SistemaCadastroLivrosPOO;

public class Funcionario : Pessoa
{
	public string Cargo { get; set; }

	public Funcionario(string Nome, string CPF, string Cargo) : base(Nome, CPF)
	{
		this.Cargo = Cargo;
	}

	public override void ObterIdentificacao()
	{
		Console.WriteLine($"Funcionario: {Nome}, CPF: {CPF}, Cargo: {Cargo}");
	}
}