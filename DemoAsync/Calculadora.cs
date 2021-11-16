public class Calculadora
{
    public static async Task<int> CalculoAsync(int x)
    {
        await Task.Delay(5000);
        return (int)Math.Pow(x, 100); //com async
        //return Task.FromResult((int)Math.Pow(x, 100)); //sem async
    }
}