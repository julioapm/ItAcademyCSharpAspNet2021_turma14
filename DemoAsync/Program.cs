Console.WriteLine("Vou fazer um cálculo demorado");
/*
var resultado = Calculadora.CalculoAsync(2);
Console.WriteLine($"Status: {resultado.Status}");
Console.WriteLine($"Resultado: {resultado.Result}");
*/
var resultado = await Calculadora.CalculoAsync(2);
Console.WriteLine($"Resultado: {resultado}");