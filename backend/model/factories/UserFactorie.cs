
namespace Factory {
    public class UserFactorie : AbstractFactory<User>
    {
        public UserFactorie()
        {
            // Define o namespace específico para disciplinas
            this.pacoteBase += ".User";
        }
    }
}
