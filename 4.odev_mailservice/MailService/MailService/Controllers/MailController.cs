﻿using MailService.Data;
using MailService.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MailService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class MailController : BaseController
    {
        private readonly UserManager<User> _userManager;


        public MailController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        [HttpPost("Send")]
        public IActionResult Send(MailSendModel model)
        {
            return Ok();
        }

        //[HttpPost("AddUser")]
        //public IActionResult AddUser([FromForm] User model)
        //{

        //    _userManager.CreateAsync(model);
        //    return Ok(new { UserName = model.UserName, Success = true });
        //}

        [HttpPost("AddUser")]
        public IActionResult AddUser(User model)
        {

            _userManager.CreateAsync(model);
            return Ok(new { UserName = model.UserName, Success = true });
        }

        [HttpGet("GetUsers")]
        public IActionResult GetUsers()
        {
            List<string> users = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                users.Add(i.ToString());
            }
            return Ok(users);
        }
    }
}
