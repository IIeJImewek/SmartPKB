using Microsoft.AspNetCore.Mvc;
using SmartPKBHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SmartPKBHub.Utils;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartPKBHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        SmartPKBServerContext dbContext = new SmartPKBServerContext();
        // POST api/<LoginController>
        [HttpPost]
        public string Post([FromBody] User value)
        {
            try
            {
                //Проверяем существует ли пользователь
                if (dbContext.Users.Any(user => user.Username.Equals(value.Username)))
                {
                    User user = dbContext.Users.Where(user => user.Username.Equals(value.Username)).First();
                    //Считываем хэш пароля из данных пользователя и сравниваем с тем, что хранится на сервере
                    var clientHashedPassword = Convert.ToBase64String(
                        Common.SaltHashPassword(
                            Encoding.ASCII.GetBytes(value.Password),
                            Convert.FromBase64String(user.Salt)));
                    if (clientHashedPassword.Equals(user.Password))
                        return JsonConvert.SerializeObject(user);
                    else
                        return JsonConvert.SerializeObject("Неверный пароль").TrimStart('"').TrimEnd('"');
                }
                else
                {
                    return JsonConvert.SerializeObject("Такого пользователя не существует").TrimStart('"').TrimEnd('"');
                }
            }
            catch 
            {
                return JsonConvert.SerializeObject("Ошибка").TrimStart('"').TrimEnd('"');
            }
        }
    }
}
