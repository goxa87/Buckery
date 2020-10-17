using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask_PetrovGN.Models
{
    /// <summary>
    /// Уменньшатель цены на половину
    /// </summary>
    public class HalfLifePriceDescreaser : IPriceDescreaser
    {
        public IBun Bun { get; }

        public HalfLifePriceDescreaser(IBun bun)
        {
            Bun = bun;
        }

        public bool IsBunAlive
        {
            // перенести
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
            // Цена уменьшается вдвое после достижения контрольного значения
            return Bun.ControlFreshPeriod < DateTime.Now ? Bun.StartPrice / 2 : Bun.StartPrice;
        }

        public DateTime WhenBunDie()
        {
            var timespan = Bun.StorageLife.Ticks;
            return Bun.CreationDate.AddTicks(timespan);
        }
    }
}
