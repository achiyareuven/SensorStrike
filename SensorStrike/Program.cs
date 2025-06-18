using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SensorStrike.Game;

namespace SensorStrike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameManager game = new GameManager();
            game.Start();
        }
    }
}
