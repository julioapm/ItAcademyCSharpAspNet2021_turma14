public enum EstadoBinario
{
    Desligado,
    Ligado
}

public interface IEstadoBinario
{
    EstadoBinario Estado { get; }
    void Ligar();
    void Desligar();
}