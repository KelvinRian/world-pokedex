namespace WorldPokedex.Domain.Entities.Base
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public bool Active { get; set; } = true;
    }
}
