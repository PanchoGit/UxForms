using UxForms.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UxForms.Repository.Configurations;

namespace UxForms.Repository.Maps
{
    public class FormMap : EntityMappingConfiguration<Form>
    {
        public override void Map(EntityTypeBuilder<Form> builder)
        {
        }
    }
}
