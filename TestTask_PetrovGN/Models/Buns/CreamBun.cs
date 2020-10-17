using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask_PetrovGN.Models
{
    public class CreamBun : IBun
    {
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }

        public DateTime ControlFreshPeriod { get; set; }

        public TimeSpan StorageLife { get; set; }
        public double StartPrice { get; set; }
        public bool IsAlive
        {
            get
            {
                return this.PriceDescreaser.IsBunAlive;
            }
        }

        public double CurentPrice
        {
            get
            {
                return this.PriceDescreaser.GetCurrentPrice();
            }
        }

        public IPriceDescreaser PriceDescreaser { get; set; }

        public CreamBun()
        {
            PriceDescreaser = new SuperFastPriceDescreaser(this);
            Name = "Кремовое ПироженоЭ";
            CreationDate = DateTime.Now;
            ControlFreshPeriod = DateTime.Now.AddMinutes(15);
            StorageLife = TimeSpan.FromSeconds(30 * 60);
            StartPrice = 100;
            
        }
    }
}
