using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Data.Entities;

namespace Web.API.Controllers
{
    [Authorize]
    public class EmployeesController : ApiController
    {
        private SkyEntities entities = new SkyEntities();
        public IEnumerable<Employee> Get()
        {
            using (entities)
            {
                return entities.Employees.ToList();
            }
        }
    }
}
