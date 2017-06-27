using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UxForms.Repository.Interfaces;

namespace UxForms.Repository.Configurations
{
    public abstract class EntityMappingConfiguration<T> : IEntityMappingConfiguration<T> where T : class
    {
        public abstract void Map(EntityTypeBuilder<T> mapper);

        public void Map(ModelBuilder mapper)
        {
            Map(mapper.Entity<T>());
        }
    }
}
