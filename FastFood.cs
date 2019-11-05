using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FastFood : IFood
    {
        public void ExecuteFunction(IGameManager gameManager)
        {
            gameManager.IncreaseLength(1);
            gameManager.IncreaseSpeed(5);
        }
    }
}
