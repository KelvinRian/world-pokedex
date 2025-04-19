using WorldPokedex.Domain.Entities.Base;

namespace WorldPokedex.Domain.Entities
{
    public class Region : BaseEntity
    {
        public string Name { get; set; }
        public string CoverImagePath { get; set; }
    }
}
