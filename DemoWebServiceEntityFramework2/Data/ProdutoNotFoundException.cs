public class ProdutoNotFoundException : Exception
{
    public ProdutoNotFoundException(int id)
        : base($"Produto com o id {id} não foi encontrado")
    {
    }
}