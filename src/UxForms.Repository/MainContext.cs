using Microsoft.EntityFrameworkCore;
using System.Reflection;
using UxForms.Repository.Extensions;

namespace UxForms.Repository
{
    public class MainContext : DbContext
    {
        private const string AppSchema = "app";
        private const string RepositoryAssemblyName = "UxForms.Repository";

        public MainContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(AppSchema);

            modelBuilder.AddEntityConfigurationsFromAssembly(Assembly.Load(new AssemblyName(RepositoryAssemblyName)));

            base.OnModelCreating(modelBuilder);
        }
    }
}
