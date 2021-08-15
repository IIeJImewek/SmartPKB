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
    public class HeatingController : ControllerBase
    {
        SmartPKBServerContext dbContext = new SmartPKBServerContext();
        // GET: api/<HeatingController>
        [HttpGet]
        public List<Heating> GetAll()
        {
            List<Heating> heatings = dbContext.Heatings.Select(h => new Heating()
            {
                Id = h.Id,
                Name = h.Name,
                Temp = h.Temp,
                CurOutput = h.CurOutput,
                NormOutput = h.NormOutput,
                MaxOutput = h.MaxOutput,
                Nroom = h.Nroom,
                Turned = h.Turned,
            }).ToList();
            return heatings;
        }

        // GET api/<HeatingController>/Nroom=5
        [HttpGet("Nroom={nroom}")]
        public List<Heating> GetAllInRoom(int nroom)
        {
            List<Heating> heatings = dbContext.Heatings.Select(h => new Heating()
            {
                Id = h.Id,
                Name = h.Name,
                Temp = h.Temp,
                CurOutput = h.CurOutput,
                NormOutput = h.NormOutput,
                MaxOutput = h.MaxOutput,
                Nroom = h.Nroom,
                Turned = h.Turned,
            }).Where(h => h.Nroom == nroom).ToList();
            return heatings;
        }

        [HttpGet("{id}")]
        public Heating GetOne(int id)
        {
            Heating heating = dbContext.Heatings.Where(h => h.Id == id).FirstOrDefault<Heating>();
            return heating;
        }

        // PUT api/<HeatingController>
        [HttpPut]
        public string Put([FromBody] Heating value)
        {
            Heating existingHeating = dbContext.Heatings.Where(h => h.Id == value.Id).FirstOrDefault<Heating>();
            if (existingHeating!=null)
            {
                try
                {
                    existingHeating.Temp = value.Temp;
                    existingHeating.CurOutput = value.CurOutput;
                    existingHeating.Turned = value.Turned;
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
                return JsonConvert.SerializeObject("Такого обогревателя не существует").TrimStart('"').TrimEnd('"');
            }
        }
    }
}
