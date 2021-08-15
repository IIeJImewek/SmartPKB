using Microsoft.AspNetCore.Mvc;
using SmartPKBHub.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SmartPKBHub.Utils;
using System.Text;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SmartPKBHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LightningController : ControllerBase
    {
        SmartPKBServerContext dbContext = new SmartPKBServerContext();
        // GET: api/<LightningController>
        [HttpGet]
        public List<Lightning> GetAll()
        {
            List<Lightning> lightnings = dbContext.Lightnings.Select(l => new Lightning()
            {
                Id = l.Id,
                Name = l.Name,
                Value = l.Value,
                MaxOutput = l.MaxOutput,
                Nroom = l.Nroom,
                Turned = l.Turned,
            }).ToList();
            return lightnings;
        }

        [HttpGet("Nroom={nroom}")]
        public List<Lightning> GetAllInRoom(int nroom)
        {
            List<Lightning> lightnings = dbContext.Lightnings.Select(l => new Lightning()
            {
                Id = l.Id,
                Name = l.Name,
                Value = l.Value,
                MaxOutput = l.MaxOutput,
                Nroom = l.Nroom,
                Turned = l.Turned,

            }).Where(l => l.Nroom == nroom).ToList();
            return lightnings;
        }

        [HttpGet("{id}")]
        public Lightning GetOne(int id)
        {
            Lightning light = dbContext.Lightnings.Where(l => l.Id == id).FirstOrDefault<Lightning>();
            return light;
        }
        // PUT api/<LightningController>/5
        [HttpPut]
        public string Put([FromBody] Lightning value)
        {
            Lightning existingLight = dbContext.Lightnings.Where(l => l.Id == value.Id).FirstOrDefault<Lightning>();
            //Проверяем, на существование источника света с таким Id
            if (existingLight!= null)
            {
                //Добавляем такого пользователя
                try
                {
                    existingLight.Value = value.Value;
                    existingLight.Turned = value.Turned;
                    dbContext.SaveChanges();
                    return JsonConvert.SerializeObject("Данные обновлены").TrimStart('"').TrimEnd('"');
                }
                catch (Exception ex)
                {
                    return JsonConvert.SerializeObject(ex.Message).TrimStart('"').TrimEnd('"');
                }
            }
            else
            {
                return JsonConvert.SerializeObject("Такого источника освещения не существует").TrimStart('"').TrimEnd('"');
            }
        }
    }
}
