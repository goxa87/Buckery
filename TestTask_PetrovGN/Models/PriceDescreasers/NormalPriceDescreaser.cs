using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask_PetrovGN.Models
{

    /// <summary>
    /// Стратегия уменьшения цены Оч быстро
    /// </summary>
    public class NormalPriceDescreaser : IPriceDescreaser
    {
        public IBun Bun { get; }

        public NormalPriceDescreaser(IBun bun)
        {
            Bun = bun;
        }

        public bool IsBunAlive { 
            get 
            {
                var dieTime = this.WhenBunDie();
                if(dieTime < DateTime.Now)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            } 
        }

        public double GetCurrentPrice()
        {
            // Цена уменьшается каждый час на 2%
            // Поставлю минуты для наглядности
            var now = DateTime.Now;
            var creation = Bun.CreationDate;
            var timeInterval = Math.Round((now - creation).TotalMinutes,0);

            return Bun.StartPrice - (Bun.StartPrice * 0.02) * timeInterval;
        }

        public DateTime WhenBunDie()
        {
            var timespan = Bun.StorageLife.Ticks;
            return Bun.CreationDate.AddTicks(timespan);
        }
    }
}
