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
            _agants.Add(AgentFactory.CreateAgent(AgentRank.FootSoldier, "aly muahmad", " 7808990", "Revolutionary Guards"));
            _agants.Add(AgentFactory.CreateAgent(AgentRank.SquadLeader, "Ahmed", "9321892", "Quds Force"));
        }
        public bool HasMoreStages() => _currentStage < _agants.Count;

        public void NextAgant() => _currentStage++;


        public IranAgent GetCurrentAgent()
        {
            return _agants [_currentStage];
        }
    }
}
