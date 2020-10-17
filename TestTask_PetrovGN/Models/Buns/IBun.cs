using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask_PetrovGN.Models
{
    /// <summary>
    /// Модель булочки
    /// </summary>
    public interface IBun
    {
        /// <summary>
        /// Название
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// Контрольны срок несвежести
        /// </summary>
        public DateTime ControlFreshPeriod { get; }
        /// <summary>
        /// Срок годности (скалярное время)
        /// </summary>
        public TimeSpan StorageLife { get; }
        /// <summary>
        /// Жива ли
        /// </summary>
        public bool IsAlive { get;}
        /// <summary>
        /// Начальная цена
        /// </summary>
        public double StartPrice { get; }
        /// <summary>
        /// Текущая цена
        /// </summary>
        public double CurentPrice { get; }

        /// <summary>
        /// Стратегия уменьшения цены
        /// </summary>
        public IPriceDescreaser PriceDescreaser { get; }
    }
}
