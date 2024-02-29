using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using xquant.Models;

namespace xquant.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private readonly IConfiguration _configuration;

        public UsersController(IConfiguration configuration)
        {
          _configuration = configuration;
        }


        [HttpPost]
        [Route("registration")]
        public Response register(Users users) 
        {

            DAL dal = new DAL();
            Response response = new Response();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("EMedCS").ToString());
            response = dal.register(users, connection);
            return response;
        
        }


        [HttpPost]
        [Route("Login")]
        public Response login(Users users)
        {
            DAL dAL = new DAL();
            SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("").ToString());
            Response response = new Response();

            response = dAL.login(users, connection);
            return response;
        }
    }
}
