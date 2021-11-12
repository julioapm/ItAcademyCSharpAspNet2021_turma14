public class Lampada : IEstadoBinario
{
    private bool ligada;
    private int voltagem;
    private int potencia;
    public Lampada(int v, int p)
    {
        ligada = false;
        voltagem = v;
        potencia = p;
    }
    public EstadoBinario Estado => ligada ? EstadoBinario.Ligado : EstadoBinario.Desligado;

    public void Desligar()
    {
        ligada = false;
    }

    public void Ligar()
    {
        ligada = true;
    }
}