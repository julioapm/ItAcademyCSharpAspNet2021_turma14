int[] array = {1, 2, 3, 4, 5};

for(int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}

foreach (var x in array)
{
    Console.WriteLine(x);
}

Array.ForEach(array, Console.WriteLine);

string[] palavras = new string[3];
palavras[0] = "C#";
palavras[1] = "é";
palavras[2] = "Legal";

int[,] matriz = new int[3, 3];
matriz[0, 0] = 1;
matriz[1, 2] = 2;

bool[,,] cubo = new bool[3, 3, 3];

int[][] jagged = new int[3][];
jagged[0] = new int[3];
jagged[1] = new int[2];