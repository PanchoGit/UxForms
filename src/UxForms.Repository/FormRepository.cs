using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using UxForms.Domain;
using UxForms.Repository.Interfaces;

namespace UxForms.Repository
{
    public class FormRepository : RepositoryBase<Form, int>, IFormRepository
    {

        public FormRepository(MainContext context) : base(context)
        {
        }

        public IEnumerable<Form> Get()
        {
            return set.ToListAsync().Result;
        }
    }
}
