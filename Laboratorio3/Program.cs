/*
List<string> listaStrings = new List<string>();
Console.WriteLine(listaStrings.Count);
listaStrings.Add("Alô");
listaStrings.Add("Mundo");
listaStrings.Add("!");
Console.WriteLine(listaStrings.Count);
Console.WriteLine(listaStrings[0]);
listaStrings[0] = "Hola";
var achei = listaStrings.Find(s => s.StartsWith("M"));
Console.WriteLine(achei);
var listaImutavel = listaStrings.AsReadOnly();
foreach (var item in listaImutavel)
{
    Console.WriteLine(item);
}
*/

Dictionary<int,string> paises = new Dictionary<int,string>();
paises[44] = "Reino Unido";
paises[33] = "França";
paises[55] = "Brasil";
Console.WriteLine($"O código 55 é {paises[55]}");
paises.Keys.ToList().ForEach(Console.WriteLine);
foreach (var item in paises)
{
    Console.WriteLine($"Código {item.Key} = {item.Value}");
}