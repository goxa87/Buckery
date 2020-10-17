using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask_PetrovGN.Models;
using TestTask_PetrovGN.ViewModels;

namespace TestTask_PetrovGN.Services
{
    public class BackaryStorage : IBackaryStorage
    {
        public List<IBun> Buns { get; set; }

        public BackaryStorage()
        {
            Buns = new List<IBun>();
            ReCreateAllBuns();
        }
        public void AddNewBuns()
        {
            var buns = new List<IBun>();
            IFactory factory = new CroissantFactory();
            buns.Add(factory.CreateBun());
            factory = new PretzelFactory();
            buns.Add(factory.CreateBun());
            factory = new CreamBunFactory();
            buns.Add(factory.CreateBun());
            this.Buns.AddRange(buns);
        }

        public IEnumerable<BunVM> GetAllBuns()
        {
            return this.Buns.Select(e=>new BunVM() {
                Name = e.Name,
                CreationDate = e.CreationDate.ToString("dd.MM HH.mm.ss"),
                ControlFreshPeriod = e.ControlFreshPeriod.ToString("dd.MM HH.mm.ss"),
                StartPrice = e.StartPrice,
                StorageLife = e.CreationDate.AddMilliseconds(e.StorageLife.TotalMilliseconds).ToString("dd.MM HH.mm.ss"),
                CurentPrice = Math.Round(e.CurentPrice,2),
                IsAlive = e.IsAlive? "О да": "Ой нет"
            });
        }

        public void ReCreateAllBuns()
        {
            var buns = new List<IBun>();
            IFactory factory = new CroissantFactory();
            buns.Add(factory.CreateBun());
            factory = new PretzelFactory();
            buns.Add(factory.CreateBun());
            factory = new CreamBunFactory();
            buns.Add(factory.CreateBun());
            this.Buns = buns;
        }
    }
}
