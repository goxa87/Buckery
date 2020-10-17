using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestTask_PetrovGN.Models;
using TestTask_PetrovGN.Services;
using TestTask_PetrovGN.ViewModels;

namespace TestTask_PetrovGN.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class BunController: ControllerBase
    {

        private readonly IBackaryStorage storage;
        public BunController(IBackaryStorage _storage)
        {
            storage = _storage;
        }

        /// <summary>
        /// Получить данные
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<BunVM> Get()
        {
            var buns = storage.GetAllBuns();
            return buns;
        }

        /// <summary>
        /// Сделать булок с заменой старых
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public StatusCodeResult CreateNewBuns()
        {
            storage.ReCreateAllBuns();
            return Ok();
        }
        /// <summary>
        /// Сделать булок вдобавку
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public StatusCodeResult AddBuns()
        {
            storage.AddNewBuns();
            return Ok();
        }
    }
}
