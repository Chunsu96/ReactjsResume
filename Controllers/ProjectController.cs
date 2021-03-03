using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PortfolioUsingReact.Models;

namespace PortfolioUsingReact.Controllers
{
    [Route("api/projects")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        public IEnumerable<Project> GetProjects()
        {
            string jsonText = System.IO.File.ReadAllText("./Data/projects.json");
            return JsonConvert.DeserializeObject<IEnumerable<Project>>(jsonText);
        }
    }
}
