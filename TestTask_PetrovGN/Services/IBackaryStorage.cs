using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask_PetrovGN.Models;
using TestTask_PetrovGN.ViewModels;

namespace TestTask_PetrovGN.Services
{
    public interface IBackaryStorage
    {
        List<IBun> Buns { get; set; }

        /// <summary>
        /// Пересоздаст все булки
        /// </summary>
        void ReCreateAllBuns();
        /// <summary>
        /// Добавит новые к существующим
        /// </summary>
        void AddNewBuns();
        /// <summary>
        /// Верент весь список булок
        /// </summary>
        /// <returns></returns>
        IEnumerable<BunVM> GetAllBuns();
    }
}
