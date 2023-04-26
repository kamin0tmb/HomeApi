using System.Threading.Tasks;
using HomeApi.Data.Models;
using HomeApi.Data.Queries;

namespace HomeApi.Data.Repos
{
    /// <summary>
    /// Интерфейс определяет методы для доступа к объектам типа Room в базе 
    /// </summary>
    public interface IRoomRepository
    {
        /// <summary>
        /// Выгрузить все комнаты
        /// </summary>
        Task<Room[]> GetRooms();
        /// <summary>
        ///  Найти комнату по имени
        /// </summary>
        Task<Room> GetRoomByName(string name);

        /// <summary>
        ///  Добавить новую комнату
        /// </summary>
        Task AddRoom(Room room);

        /// <summary>
        /// Обновить подключенную комнату
        /// </summary>
        /// <param name="room"></param>
        /// <param name="query"></param>
        /// <returns></returns>
        Task UpdateRoom(Room room, UpdateRoomQuery query);
    }
}