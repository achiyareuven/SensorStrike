using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SensorStrike.Agants;
using SensorStrike.Enums;

namespace SensorStrike.Factorys
{
    public static class AgentFactory
    {
        public static IranAgent CreateAgent(AgentRank rank, string fullName, string idNumber, string affiliation)
        {
            switch (rank)
            {
                case AgentRank.FootSoldier:
                    return new FootSoldier(fullName, idNumber, affiliation);
                    
                default:
                    return null;
                 
            };
        }
    }
}
