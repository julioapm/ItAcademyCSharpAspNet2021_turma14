/*
Ponto ponto = new Ponto(1, 2);
Console.WriteLine(ponto);
Ponto ponto2 = new Ponto();
Console.WriteLine(ponto2);
Ponto ponto3 = ponto;
Console.WriteLine(ponto3);
ponto.Mover(new Ponto(10,10));
Console.WriteLine(ponto3);
*/

Fracao f1 = new Fracao(){
    Numerador = 1,
    Denominador = 2
};
Console.WriteLine(f1);
Fracao f2 = new Fracao(){
    Numerador = 3,
    Denominador = 2
};
Console.WriteLine(f2);
Fracao f3 = f1 + f2;
Console.WriteLine(f3);