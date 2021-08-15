using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Refit;
using SmartPKBLuxmeter.Models;

namespace SmartPKBLuxmeter.API
{
    interface ILightningAPI
    {
        [Get("/api/lightning")]
        Task<List<Lightning>> GetLightnings();

        [Get("/api/lightning/Nroom={nroom}")]
        Task<List<Lightning>> GetLightningsByRoom(int nroom);

        [Get("/api/rooms")]
        Task<List<Room>> GetRooms();

        [Get("/api/rooms/{id}")]
        Task<Room> GetRoomById(int id);
    }
}   
