using System.Text;

/*
byte b;
b = byte.MaxValue;
Console.WriteLine("Valor máximo de byte:");
Console.WriteLine(b);
Console.WriteLine($"Valor máximo de byte: {b}");

string strPrimeira = "Alô ";
string strSegunda = "Mundo!";
string strConcatenada = strPrimeira + strSegunda;
Console.WriteLine(strConcatenada);
Console.WriteLine(strConcatenada.Length);
Console.WriteLine(strConcatenada.Substring(0, 5));
Console.WriteLine(strPrimeira[0]);

DateTime dt = new DateTime(2021, 11, 10);
Console.WriteLine(dt);
Console.WriteLine(dt.ToShortDateString());
Console.WriteLine($"Hoje é {dt:dd-MM-yyyy}");
*/

int x = 0;
int y = x;
x++;
Console.WriteLine(x);
Console.WriteLine(y);


StringBuilder s = new StringBuilder();
Console.WriteLine(s);
StringBuilder t = s;
s.Append("Alô");
Console.WriteLine(s);
Console.WriteLine(t);