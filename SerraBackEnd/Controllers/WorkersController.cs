using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace SerraBackEnd.Controllers
{
    public class WorkersController : ApiController
    {
        private PracticaSerraUpdateEntities _context;

        public IHttpActionResult GetWorkerInfo()
        {
            _context = new PracticaSerraUpdateEntities();
            try
            {
                var workers = _context.GetAllWorkers().ToList();
                return Ok(workers);
            }
            catch(Exception ex)
            {
                return InternalServerError(ex);
            }
        }
        
        public IHttpActionResult GetWorkersStats()
        {
            _context = new PracticaSerraUpdateEntities();
            Hashtable Stats_hashtable = new Hashtable();

            try
            {
                var max = _context.BiggestQuantity();
                var nmax = _context.NumberOfProductiveWorkers();
                var tq = _context.TotalQuantity();
                var aq = _context.AverageQuantity();
                Stats_hashtable.Add("Biggest Quantity", max);
                Stats_hashtable.Add("Workers that got a big Quantity", nmax);
                Stats_hashtable.Add("Total Quantity picked Up today:", tq);
                Stats_hashtable.Add("Average Quantity per Worker", aq);
                return Ok(Stats_hashtable);
            }
            catch(Exception ex)
            {
                return InternalServerError();
            }
        }
        

       
    }
}
