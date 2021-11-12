IList<IEstadoBinario> coisas = new List<IEstadoBinario>();
coisas.Add(new Lampada(110,60));
coisas.Add(new Lampada(110,40));
coisas.Add(new TermometroEletrico());

foreach (var coisa in coisas)
{
    coisa.Ligar();
}

foreach (var coisa in coisas)
{
    Console.WriteLine(coisa.Estado);
}