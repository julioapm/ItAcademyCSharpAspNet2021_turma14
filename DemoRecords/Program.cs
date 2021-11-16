Pessoa p1 = new Pessoa("João", 20);
Console.WriteLine(p1.Nome);
Console.WriteLine(p1);
Pessoa p2 = new Pessoa("João", 20);
Console.WriteLine(p1 == p2);
Console.WriteLine(p1.Equals(p2));
Pessoa p3 = p1 with { Idade = 30 };
Console.WriteLine(p3);