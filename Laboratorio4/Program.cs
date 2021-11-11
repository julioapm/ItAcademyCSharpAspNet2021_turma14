ContaCorrente c = new ContaCorrente(1M, "12345678901");
c.Depositar(100.50M);
c.Sacar(10M);
Console.WriteLine(c.Saldo);
Console.WriteLine(c.DataAbertura);
Console.WriteLine(c.CpfTitular);

var c2 = new ContaCorrente();
Console.WriteLine(c2.Saldo);
Console.WriteLine(c2.DataAbertura);

var c3 = new ContaCorrente{
    CpfTitular = "12345678901"
};
