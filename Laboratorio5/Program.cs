Circulo c1 = new Circulo();
CirculoColorido c2 = new CirculoColorido(2,3,1,"amarelo");

Console.WriteLine(c1.ToString());
Console.WriteLine(c2.ToString());

Circulo c3 = new CirculoColorido(2,3,1,"amarelo");
Console.WriteLine(c3.ToString());

Circulo c4 = c2;

Console.WriteLine(c2 == c3);
Console.WriteLine(c2.Equals(c3));
Console.WriteLine(c2 == c4);
Console.WriteLine(c2.Equals(c4));