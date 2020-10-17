using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestTask_PetrovGN.Models
{
    public class PretzelFactory : IFactory
    {
        public IBun CreateBun()
        {
            return new Pretzel();
        }
    }
}
