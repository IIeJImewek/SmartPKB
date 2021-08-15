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
    public class RegistrationController : ControllerBase
    {
        SmartPKBServerContext dbContext = new SmartPKBServerContext();
        // POST api/<RegistrationController>
        [HttpPost]
        public string Post([FromBody] User value)
        {
            //Проверяем, на существование пользователя с таким логином
            if(!dbContext.Users.Any(user => user.Username.Equals(value.Username)))
            {
                User user = new User();
                user.Username = value.Username; //присваиваем значение из POST запроса
                user.Salt = Convert.ToBase64String(Common.GetRandomSalt(16));
                user.Password = Convert.ToBase64String(Common.SaltHashPassword(Encoding.ASCII.GetBytes(value.Password), Convert.FromBase64String(user.Salt)));

                //Добавляем такого пользователя
                try
                {
                    dbContext.Add(user);
                    dbContext.SaveChanges();
                    return JsonConvert.SerializeObject("Пользователь успешно зарегистрирован").TrimStart('"').TrimEnd('"');
                }
                catch(Exception ex)
                {
                    return JsonConvert.SerializeObject(ex.Message).TrimStart('"').TrimEnd('"');
                }
            }
            else
            {
                return JsonConvert.SerializeObject("Пользователь с таким логином уже существует").TrimStart('"').TrimEnd('"');
            }
        }
    }
}
