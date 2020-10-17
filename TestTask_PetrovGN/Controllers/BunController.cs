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

        [HttpGet]
        public IEnumerable<BunVM> Get()
        {
            var buns = storage.GetAllBuns();
            return buns;
        }

        [HttpGet]
        public StatusCodeResult CreateNewBuns()
        {
            storage.ReCreateAllBuns();
            return Ok();
        }

        [HttpGet]
        public StatusCodeResult AdBuns()
        {
            storage.AddNewBuns();
            return Ok();
        }
    }
}
