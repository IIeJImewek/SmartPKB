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
    public class RoomsController : ControllerBase
    {
        SmartPKBServerContext dbContext = new SmartPKBServerContext();
        // GET: api/<RoomsController>
        [HttpGet]
        public List<Room> Get()
        {
            List<Room> rooms = dbContext.Rooms.Select(r => new Room()
            {
                Id = r.Id,
                Name = r.Name,
                Area = r.Area,
                Nlux = r.Nlux,
                CurTemp = r.CurTemp,
            }).ToList();
            return rooms;
        }

        // GET api/<RoomsController>/5
        [HttpGet("{id}")]
        public Room Get(int id)
        {
            Room room = dbContext.Rooms.Where(r => r.Id == id).FirstOrDefault<Room>();
            return room;
        }

        // PUT api/<RoomsController>/5
        [HttpPut]
        public string Put([FromBody] Room value)
        {
            Room existingRoom = dbContext.Rooms.Where(l => l.Id == value.Id).FirstOrDefault<Room>();
            //Проверяем, на существование источника света с таким Id
            if (existingRoom != null)
            {
                //Добавляем такого пользователя
                try
                {
                    existingRoom.CurTemp = value.CurTemp;
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
                return JsonConvert.SerializeObject("Такой комнаты не существует").TrimStart('"').TrimEnd('"');
            }
        }
    }
}
