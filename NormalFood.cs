using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class NormalFood : IFood
    {
        public void ExecuteFunction(IGameManager gameManager)
        {
            gameManager.IncreaseLength(1);
        }
    }
}
