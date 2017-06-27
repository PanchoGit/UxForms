using System.Collections.Generic;
using UxForms.Domain;

namespace UxForms.Workflow.Interfaces
{
    public interface IFormWorkflow
    {
        IEnumerable<Form> Get();

        Form Post(Form form);
    }
}
