public class ContaCorrente
{
    private decimal saldo;

    public ContaCorrente(decimal valor, string? cpf)
    {
        saldo = valor;
        DataAbertura = DateTime.Now;
        CpfTitular = cpf;
    }
    public ContaCorrente()
    : this(0M, null)
    {
    }

    public void Depositar(decimal valor)
    {
        saldo = saldo + valor;
    }

    public void Sacar(decimal valor)
    {
        saldo = saldo - valor;
    }

    public decimal Saldo
    {
        get
        {
            return saldo;
        }
    }

    public DateTime DataAbertura { get; }
    public string? CpfTitular { get; set; }
}