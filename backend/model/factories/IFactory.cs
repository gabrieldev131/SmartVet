namespace Factory {
    public interface IFactory<T>
    {
        T Criar(string opcao);
    }
}