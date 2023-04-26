using System;
using System.Threading.Tasks;
using HomeApi.Data.Models;
using HomeApi.Data.Queries;

namespace HomeApi.Data.Repos
{
    /// <summary>
    /// Интерфейс определяет методы для доступа к объектам типа Device в базе 
    /// </summary>
    public interface IDeviceRepository
    {
        /// <summary>
        /// Выгрузить все устройства
        /// </summary>
        Task<Device[]> GetDevices();
        /// <summary>
        /// Найти устройство по имени
        /// </summary>
        Task<Device> GetDeviceByName(string name);
        /// <summary>
        /// Найти устройство по идентификатору
        /// </summary>
        Task<Device> GetDeviceById(Guid id);
        /// <summary>
        /// Добавить новое устройство
        /// </summary>
        Task SaveDevice(Device device, Room room);
        /// <summary>
        /// Обновить существующее устройство
        /// </summary>
        Task UpdateDevice(Device device, Room room, UpdateDeviceQuery query);
        /// <summary>
        /// Удалить устройство
        /// </summary>
        Task DeleteDevice(Device device);
    }
}