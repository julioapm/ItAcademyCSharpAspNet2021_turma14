List<Pessoa> pessoas = new List<Pessoa>
{
    new Pessoa("Ana", new DateTime(1980,3,14), true),
    new Pessoa("Paulo", new DateTime(1978,10,23), true),
    new Pessoa("Maria", new DateTime(2000,1,10), false),
    new Pessoa("Carlos", new DateTime(1999,12,12), false),
};

var linq1 = from p in pessoas
            where p.Casada && p.DataNascimento >= new DateTime(1980, 1, 1)
            select p;
foreach (var p in linq1)
{
    Console.WriteLine(p);
}

var linq2 = pessoas.Where(p => p.Casada && p.DataNascimento >= new DateTime(1980, 1, 1));
linq2.ToList().ForEach(p => Console.WriteLine(p));

var linq3 = from p in pessoas
            where !p.Casada
            select p.Nome;
foreach (var p in linq3)
{
    Console.WriteLine(p);
}

var linq3v2 = pessoas
              .Where(p => !p.Casada)
              .Select(p => p.Nome);


var linq4 = from p in pessoas
            where p.Casada
            select new {p.Nome, p.DataNascimento};
foreach (var p in linq4)
{
    Console.WriteLine($"Nome={p.Nome} DataNascimento={p.DataNascimento.ToShortDateString()}");
}

var linq5 = from p in pessoas
            orderby p.DataNascimento descending, p.Nome
            select p;
foreach (var p in linq5)
{
    Console.WriteLine(p);
}
var linq5v2 = pessoas
              .OrderByDescending(p => p.DataNascimento)
              .ThenBy(p => p.Nome);

var linq6 = from p in pessoas
            group p by p.Casada into grupo
            select new { Casados = grupo.Key, Pessoas = grupo };
foreach (var agrupamento in linq6)
{
    Console.WriteLine($"Casados={agrupamento.Casados}");
    foreach (var p in agrupamento.Pessoas)
    {
        Console.WriteLine($"\t{p}");
    }
}