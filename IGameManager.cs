using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    interface IGameManager
    {
        void IncreaseLength(int n);
        void DecreaseLength(int n);
        void SetDirection();
        void SetView();
        void ReverseDirection();
        void SetScoreFormular();
        void IncreaseSpeed(int n);
        void DecreaseSpeed(int n);
    }
}
