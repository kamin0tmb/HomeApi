namespace HomeApi.Contracts.Models.Devices
{
    /// <summary>
    /// Запрос для удаления подключенного устройства
    /// </summary>
    public class DeleteDeviceRequest
    {
        public string Room { get; set; }
        public string Name { get; set; }
    }
}
