using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.Http;


namespace SerraBackEnd.Controllers
{
    public class UtilizatoriController : ApiController
    {
        private PracticaSerraUpdateEntities _context; //obiect ce tine loc de conexiune la baza de date

        public IHttpActionResult GetUtilizatotiInfo()
        {
            _context = new PracticaSerraUpdateEntities();
            try
            {
                var users = _context.GetAllUsers().ToList();
                return Ok(users);
            }
            catch(Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        public IHttpActionResult AddUtilizatori([FromBody] dynamic Utilizator)
        {
            _context = new PracticaSerraUpdateEntities();
            try
            {
                String username = Utilizator["Username"];
                String password = Utilizator["Password"];
                String nume = Utilizator["Nume"];
                String prenume = Utilizator["Prenume"];
                String email  = Utilizator["email"];
                decimal telephone = Utilizator["telephone"];
                _context.AddUtilizator(username, password, nume, prenume, email, telephone, 0);
                return Ok("Adaugat");

            }
            catch(Exception ex)
            {
                return InternalServerError();
            }
        }

        public IHttpActionResult DeleteUtilizatori(int userID)
        {
            _context = new PracticaSerraUpdateEntities();
            try
            {
                _context.DeleteUtilizatori(userID);
                return Ok("deleted");
            }
            catch(Exception ex)
            {
                return InternalServerError();
            }
        }

        public IHttpActionResult UpdateUsers([FromBody] dynamic userInfo)
        {
            _context = new PracticaSerraUpdateEntities();
            try
            {
                
                String nume = userInfo["Nume"];
                String prenume = userInfo["Prenume"];
                String email = userInfo["email"];
                decimal telephone = userInfo["telephone"];
                _context.UpdateUtilizator(0, nume, prenume, email, telephone);
                return Ok("Updated");
            }
            catch(Exception ex)
            {
                return InternalServerError();
            }
            
        }


    }
}
