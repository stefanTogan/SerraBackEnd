using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace SerraBackEnd.Controllers
{
    public class PlantationController : ApiController
    {
        private PracticaSerraUpdateEntities _context;

        public IHttpActionResult GetPlantationInfo()
        {
            _context = new PracticaSerraUpdateEntities();
            try
            {
                dynamic plantations = _context.GetAllPlantations();
                return Ok(plantations);
            }
            catch(Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}