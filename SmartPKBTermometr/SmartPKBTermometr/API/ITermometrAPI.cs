using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Refit;
using SmartPKBTermometr.Models;

namespace SmartPKBTermometr.API
{
    interface ITermometrAPI
    {
        [Get("/api/rooms")]
        Task<List<Room>> GetRooms();

        [Get("/api/rooms/{id}")]
        Task<Room> GetRoomById(int id);

        [Put("/api/rooms")]
        Task<string> UpdateRoom([Body] Room room);

        [Get("/api/airconditioning/Nroom={nroom}")]
        Task<List<AirConditioning>> GetAirConditioningsByRoom(int nroom);

        [Get("/api/heating/Nroom={nroom}")]
        Task<List<Heating>> GetHeatingsByRoom(int nroom);

        [Put("/api/airconditioning")]
        Task<string> UpdateAirConditioning([Body] AirConditioning air);

        [Put("/api/heating")]
        Task<string> UpdateHeating([Body] Heating heating);
    }
}
