using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask_PetrovGN.Models
{
    /// <summary>
    /// Стратегия уменьшения цены Оч быстро
    /// </summary>
    public class SuperFastPriceDescreaser : IPriceDescreaser
    {
        public IBun Bun { get; }

        public SuperFastPriceDescreaser(IBun bun)
        {
            Bun = bun;
        }

        public bool IsBunAlive
        {
            get
            {
                var dieTime = this.WhenBunDie();
                if (dieTime < DateTime.Now)
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
            var timeInterval = (int)Math.Round((now - creation).TotalMinutes, 0);

            return Bun.StartPrice*(1-CalculateCoeficient(0.02, timeInterval));
        }

        public DateTime WhenBunDie()
        {
            var timespan = Bun.StorageLife.Ticks;
            return Bun.CreationDate.AddTicks(timespan);
        }

        private double CalculateCoeficient(double startKoef, int iterationsQuantity)
        {
            if (iterationsQuantity == 0)
                return 0;
            if (iterationsQuantity == 1)
                return startKoef;
            return  2 * CalculateCoeficient(startKoef, --iterationsQuantity);

        }
    }
}
