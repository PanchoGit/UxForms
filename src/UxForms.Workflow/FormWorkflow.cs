using System.Collections.Generic;
using UxForms.Domain;
using UxForms.Repository.Interfaces;
using UxForms.Workflow.Interfaces;

namespace UxForms.Workflow
{
    public class FormWorkflow : IFormWorkflow
    {
        private readonly IFormRepository repository;

        public FormWorkflow(IFormRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Form> Get()
        {
            return repository.Get();
        }

        public Form Post(Form Form)
        {
            return null;
        }
    }
}
