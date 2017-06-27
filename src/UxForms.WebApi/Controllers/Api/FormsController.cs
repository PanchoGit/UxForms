using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using UxForms.Workflow.Interfaces;
using UxForms.Domain;

namespace UxForms.WebApi.Controllers.Api
{
    [Produces("application/json")]
    [Route("api/Forms")]
    public class FormsController : Controller
    {
        private readonly IFormWorkflow workflow;

        public FormsController(IFormWorkflow workflow)
        {
            this.workflow = workflow;
        }

        [HttpGet]
        public IEnumerable<Form> Get() => workflow.Get();

        [HttpPost]
        public Form Post([FromBody]Form form) => workflow.Post(form);
    }
}