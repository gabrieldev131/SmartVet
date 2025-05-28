using System;
using System.Reflection;

namespace Factory
{
    public abstract class AbstractFactory<T> : IFactory<T>
    {
        protected string pacoteBase = "backend.model";
        
        public T Criar(string? opcao)
        {
            try
            {
                // Concatena o nome da classe ao pacote base
                string? nomeCompletoClasse = this.pacoteBase + opcao;
                
                // Usa reflexão para encontrar e instanciar a classe
                Type? tipoClasse = Type.GetType(nomeCompletoClasse) ?? throw new InvalidOperationException("Classe não encontrada: " + nomeCompletoClasse);
                
                // Instancia a classe dinamicamente
                object? instance = Activator.CreateInstance(tipoClasse) ?? throw new InvalidOperationException("Falha ao criar instância da classe: " + nomeCompletoClasse);
                return (T)instance;
            }
            catch (Exception e)
            {
                throw new InvalidOperationException("Erro ao criar instância da operação: " + e.Message);
            }
        }
    }
}
