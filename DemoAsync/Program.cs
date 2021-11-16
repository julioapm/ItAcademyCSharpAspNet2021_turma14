/*
Console.WriteLine("Vou fazer um cálculo demorado");

var resultado = Calculadora.CalculoAsync(2);
Console.WriteLine($"Status: {resultado.Status}");
Console.WriteLine($"Resultado: {resultado.Result}");

var resultado = await Calculadora.CalculoAsync(2);
Console.WriteLine($"Resultado: {resultado}");
*/
try
{
    /*
    var resultado = await ViaCepConsumidor.Consultar("01001000");
    Console.WriteLine($"Sucesso: {resultado.IsSuccessStatusCode}");
    Console.WriteLine($"StatusCode: {resultado.StatusCode}");
    var dados = await resultado.Content.ReadAsStringAsync();
    Console.WriteLine(dados);
    */
    /*
    var resultado = await ViaCepConsumidor.ConsultarV2("01001000");
    Console.WriteLine(resultado);
    */
    var resultado = await ViaCepConsumidor.ConsultarV3("01001000");
    if (resultado != null)
    {
        Console.WriteLine(resultado.Cep);
        Console.WriteLine(resultado.Logradouro);
        Console.WriteLine(resultado.Bairro);
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
