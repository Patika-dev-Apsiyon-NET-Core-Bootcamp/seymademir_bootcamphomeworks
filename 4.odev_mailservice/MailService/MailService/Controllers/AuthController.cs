using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MailService.Controllers
{

    [Route("api/[controller]")]
    [ApiController]

    public class AuthController : ControllerBase
    {
        private IConfiguration _configuration;
        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }



        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("Index")]
        public IActionResult Index()
        {
            return Ok("yetkili giriş");
        }


        [AllowAnonymous]
        [HttpGet("Login")]
        public IActionResult Login(string userName, string password)
        {
            if (userName == "s" && password == "s")
            {
                JwtService jwtService = new JwtService(_configuration);
                string token = jwtService.CreateAccessToken(new Data.Entities.User { Name = "s", Email = "s@s.com" });
                return Ok(new { token = token });
            }

            return BadRequest();
        }
    }
}
