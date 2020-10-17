using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask_PetrovGN.ViewModels
{
    public class BunVM
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Дата создания
        /// </summary>
        public string CreationDate { get; set; }
        /// <summary>
        /// Контрольный срок несвежести
        /// </summary>
        public string ControlFreshPeriod { get; set; }
        /// <summary>
        /// Срок годности (скалярное время)
        /// </summary>
        public string StorageLife { get; set; }
        /// Жива ли
        /// </summary>
        public string IsAlive { get; set; }
        /// <summary>
        /// Начальная цена
        /// </summary>
        public double StartPrice { get; set; }
        /// <summary>
        /// Текущая цена
        /// </summary>
        public double CurentPrice { get; set; }
    }
}
