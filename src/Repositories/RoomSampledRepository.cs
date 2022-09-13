using HogwartsHouses.Models;
using HogwartsHouses.Repositories.Interfaces;
using HogwartsHouses.Services;

namespace HogwartsHouses.Repositories
{
    public class RoomSampledRepository : IRepository<Room>
    {
        private RoomSampler _roomSampler { get; }

        public RoomSampledRepository()
        {
            _roomSampler = new RoomSampler();
        }
    }
}
