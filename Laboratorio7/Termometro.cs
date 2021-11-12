public class Termometro
{
    private double temperatura;
    public double Temperatura => temperatura; //propriedade de leitura
    public virtual void Aumentar(double graus) => temperatura += graus;
    public virtual void Diminuir(double graus) => temperatura -= graus;
}

public class TermometroEletrico : Termometro, IEstadoBinario
{
    private bool ligado;
    public EstadoBinario Estado => ligado ? EstadoBinario.Ligado : EstadoBinario.Desligado;

    public void Desligar()
    {
        ligado = false;
    }

    public void Ligar()
    {
        ligado = true;
    }

    public override void Aumentar(double graus)
    {
        if (ligado) base.Aumentar(graus);
    }
    public override void Diminuir(double graus)
    {
        if (ligado) base.Diminuir(graus);
    }
}