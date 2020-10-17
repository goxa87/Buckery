using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask_PetrovGN.Models
{
    /// <summary>
    /// Стратегия уменьшения цены
    /// </summary>
    public interface IPriceDescreaser
    {
        /// <summary>
        /// Сама булка
        /// </summary>
        IBun Bun { get; }
        /// <summary>
        /// Получит текущую цену
        /// </summary>
        /// <returns></returns>
        double GetCurrentPrice();
        /// <summary>
        /// Верент пригодна ли булка или нет
        /// </summary>
        bool IsBunAlive { get; }
        /// <summary>
        /// Вернет время когда булка сдохнет
        /// </summary>
        /// <returns></returns>
        DateTime WhenBunDie();
    }
}
