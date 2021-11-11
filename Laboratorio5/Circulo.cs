public class Circulo
{
    public double Raio { get; set; }
    public double CoordX { get; set; }
    public double CoordY { get; set; }
    /**
     * Construtor
     * @param r Raio do circulo deve ser maior que zero
     * @param x Coordenada X do centro do circulo
     * @param y Coordenada y do centro do circulo
     * @throws ArgumentException se r for menor que zero
     */
    public Circulo(double r, double x, double y)
    {
        if (r <= 0)
        {
            throw new ArgumentException("Raio deve ser maior que zero","r");
        }
        Raio = r;
        CoordX = x;
        CoordY = y;
    }
    
    public Circulo()
    : this(1, 0, 0)
    {
    }
    

    public override string ToString()
    {
        return base.ToString() + $"({CoordX},{CoordY}) raio={Raio}";
    }
}

public class CirculoColorido : Circulo
{
    public string Cor { get; set; }
    public CirculoColorido(double r, double x, double y, string c)
    : base(r, x, y)
    {
        Cor = c;
    }
    override public string ToString()
    {
        return base.ToString() + $" cor={Cor}";
    }
}