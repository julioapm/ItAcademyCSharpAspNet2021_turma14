public class Pessoa : IComparable<Pessoa>
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public int CompareTo(Pessoa? other)
    {
        if (other == null)
            return 1;
        return Nome.CompareTo(other.Nome);
    }

    private class PessoaIdadeComparer : IComparer<Pessoa>
    {
        public int Compare(Pessoa? x, Pessoa? y)
        {
            if (x == null)
            {
                if (y == null)
                    return 0;
                return -1;
            }
            if (y == null)
                return 1;
            return x.Idade.CompareTo(y.Idade);
        }
    }

    public static readonly IComparer<Pessoa> IdadeComparer = new PessoaIdadeComparer();
}