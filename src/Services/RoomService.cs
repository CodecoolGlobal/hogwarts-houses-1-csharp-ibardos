using HogwartsHouses.Models;
using HogwartsHouses.Repositories.Interfaces;
using HogwartsHouses.Services.Interfaces;

namespace HogwartsHouses.Services
{
    public class RoomService : IRoomService
    {
        private IRepository<Room> _repository { get; }

        public RoomService(IRepository<Room> repository)
        {
            _repository = repository;
        }
    }
}
