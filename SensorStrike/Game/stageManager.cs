using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SensorStrike.Agants;
using SensorStrike.Factorys;
using SensorStrike.Enums;

namespace SensorStrike.Game
{
    public class StageManager
    {
        private List<IranAgent> _agants = new List<IranAgent> ();
        private int _currentStage = 0;

        public StageManager()
        {
            _agants.Add(AgentFactory.CreateAgent(AgentRank.FootSoldier, "7808990", "aly muahmad", "Revolutionary Guards"));
        }
        public bool IsGameOver() => _currentStage < _agants.Count;

        public void NextAgant() => _currentStage++;


        public IranAgent GetCurrentAgent()
        {
            return _agants [_currentStage];
        }
    }
}
