using System.Collections.Generic;
using UxForms.Domain;

namespace UxForms.Repository.Interfaces
{
    public interface IFormRepository
    {
        IEnumerable<Form> Get();
    }
}
