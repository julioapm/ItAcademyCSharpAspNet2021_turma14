/*
string[] nomes = {"Julio", "Lucia", "Daniel", "Joao"};
Console.WriteLine("Antes da ordenação:");
Console.WriteLine(string.Join(", ", nomes));
Array.Sort(nomes);
Console.WriteLine("Depois da ordenação:");
Console.WriteLine(string.Join(", ", nomes));
*/
List<Pessoa> pessoas = new List<Pessoa>()
{
    new Pessoa() { Nome = "Julio", Idade = 20 },
    new Pessoa() { Nome = "Lucia", Idade = 18 },
    new Pessoa() { Nome = "Daniel", Idade = 25 },
    new Pessoa() { Nome = "Joao", Idade = 30 }
};
Console.WriteLine("Antes da ordenação:");
foreach (Pessoa p in pessoas)
{
    Console.WriteLine(p.Nome + " - " + p.Idade);
}
pessoas.Sort(Pessoa.IdadeComparer);
Console.WriteLine("Depois da ordenação:");
foreach (Pessoa p in pessoas)
{
    Console.WriteLine(p.Nome + " - " + p.Idade);
}