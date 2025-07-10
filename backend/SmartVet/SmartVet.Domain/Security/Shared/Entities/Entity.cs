namespace SmartVet.Domain.Security.Shared.Entities
{
    public abstract class Entity : IEquatable<Guid>
    {
        public Guid Id { get; protected set; }
        protected Entity() => Id = Guid.NewGuid();

        public bool Equals(Guid id) => Id == id;

        public override int GetHashCode() => Id.GetHashCode();
    }
}
