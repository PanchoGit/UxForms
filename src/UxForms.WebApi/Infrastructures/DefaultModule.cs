using Autofac;
using System.Linq;
using UxForms.WebApi.Helpers;

namespace UxForms.WebApi.Infrastructures
{
    public class DefaultModule : Module
    {
        private const string DataAssemblyEndName = "Data";
        private const string WorkflowAssemblyEndName = "Workflow";
        private const string RepositoryAssemblyEndName = "Repository";

        protected override void Load(ContainerBuilder builder)
        {
            var assemblies = AssemblyHelper.GetReferencingAssemblies("UxForms").ToArray();

            builder.RegisterAssemblyTypes(assemblies)
                .Where(s => s.Name.EndsWith(DataAssemblyEndName))
                .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(assemblies)
                .Where(s => s.Name.EndsWith(WorkflowAssemblyEndName))
                .AsImplementedInterfaces();

            builder.RegisterAssemblyTypes(assemblies)
                .Where(s => s.Name.EndsWith(RepositoryAssemblyEndName))
                .AsImplementedInterfaces();
        }
    }
}
