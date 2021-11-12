IList<IEstadoBinario> coisas = new List<IEstadoBinario>();

foreach (var coisa in coisas)
{
    coisa.Ligar();
}

foreach (var coisa in coisas)
{
    Console.WriteLine(coisa.Estado);
}