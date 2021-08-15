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
    public class AirConditioningController : ControllerBase
    {
        SmartPKBServerContext dbContext = new SmartPKBServerContext();
        // GET: api/<AirConditioningController>
        [HttpGet]
        public List<AirConditioning> GetAll()
        {
            List<AirConditioning> airs = dbContext.AirConditionings.Select(a => new AirConditioning()
            {
                Id = a.Id,
                Name = a.Name,
                Temp = a.Temp,
                MaxOutput = a.MaxOutput,
                Nroom = a.Nroom,
                Turned = a.Turned,
            }).ToList();
            return airs;
        }

        // GET api/<AirConditioningController>/5
        [HttpGet("Nroom={nroom}")]
        public List<AirConditioning> GetAllInRoom(int nroom)
        {
            List<AirConditioning> airs = dbContext.AirConditionings.Select(a => new AirConditioning()
            {
                Id = a.Id,
                Name = a.Name,
                Temp = a.Temp,
                MaxOutput = a.MaxOutput,
                Nroom = a.Nroom,
                Turned = a.Turned,
            }).Where(a => a.Nroom == nroom).ToList();
            return airs;
        }

        [HttpGet("{id}")]
        public AirConditioning GetOne(int id)
        {
            AirConditioning air = dbContext.AirConditionings.Where(a => a.Id == id).FirstOrDefault<AirConditioning>();
            return air;
        }

        // PUT api/<AirConditioningController>/5
        [HttpPut]
        public string Put([FromBody] AirConditioning value)
        {
            AirConditioning existingAir = dbContext.AirConditionings.Where(a => a.Id == value.Id).FirstOrDefault<AirConditioning>();
            if (existingAir!=null)
            {
                try
                {
                    existingAir.Temp = value.Temp;
                    existingAir.Turned = value.Turned;
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
                return JsonConvert.SerializeObject("Такого кондиционера не существует").TrimStart('"').TrimEnd('"');
            }
        }
    }
}
