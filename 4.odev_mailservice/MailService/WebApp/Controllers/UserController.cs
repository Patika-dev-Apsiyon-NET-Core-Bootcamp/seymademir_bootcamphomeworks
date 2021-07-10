using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(string userName, string email, string company)
        {
            HttpClient client = new HttpClient();
            string token;

            var response = await client.GetAsync("http://localhost:6499/api/auth/login?userName=s&password=s"); //6499

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                token = await response.Content.ReadAsStringAsync();


                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

                string serialized = JsonSerializer.Serialize(new { userName = userName, email = email, name = userName, company = company });

                StringContent content = new StringContent(serialized, Encoding.UTF8, "application/json");

                //silindi, kontrol!!! 

                await client.PostAsync("http://localhost:6499/api/mail/adduser", content);

            }

            if (response.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                string error = response.Headers.GetValues("WwwAuthorize").FirstOrDefault();
            }




            return View();
        }
    }
}
