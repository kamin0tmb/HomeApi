using System.Collections.Generic;
using System.Linq;
using FluentValidation;
using HomeApi.Contracts.Models.Devices;

namespace HomeApi.Contracts.Validation
{
    /// <summary>
    /// Класс-валидатор запросов обновления устройства
    /// </summary>
    public class DeleteDeviceRequestValidator : AbstractValidator<DeleteDeviceRequest>
    {
        /// <summary>
        /// Метод, конструктор, устанавливающий правила
        /// </summary>
        public DeleteDeviceRequestValidator() 
        {
            RuleFor(x => x.Name).NotEmpty(); 
            RuleFor(x => x.Room).NotEmpty().Must(BeSupported)
                .WithMessage($"Please choose one of the following locations: {string.Join(", ", Values.ValidRooms)}");
        }
        
        /// <summary>
        ///  Метод кастомной валидации для свойства location
        /// </summary>
        private bool BeSupported(string location)
        {
            return Values.ValidRooms.Any(e => e == location);
        }
    }
}