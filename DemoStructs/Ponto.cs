public struct Ponto
{
    public double X {get; private set;}
    public double Y {get; private set;}
    public Ponto()
    : this(0,0)
    {
    }
    public Ponto(double x, double y)
    {
        X = x;
        Y = y;
    }
    override public string ToString()
    {
        return $"({X}, {Y})";
    }
    public void Mover(Ponto destino)
    {
        X = destino.X;
        Y = destino.Y;
    }
}