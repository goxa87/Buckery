using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask_PetrovGN.Models
{
    public class CroissantFactory : IFactory
    {
        public IBun CreateBun()
        {
            return new Croissant();
        }
    }
}
