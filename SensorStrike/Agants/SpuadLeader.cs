using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SensorStrike.Enums;
using SensorStrike.halper;

namespace SensorStrike.Agants
{
    public class SpuadLeader : IranAgent
    {
        private static SensorType[] sensorTypes = new[]
        {
            SensorType.Thermal,
            SensorType.Audio,
            SensorType.Pulse,
            SensorType.Signal,
        };
        public SpuadLeader(string fullName,string idNumber,string affiliation) 
            :base
            (
                   AgentRank.SquadLeader,
                  RandomSensor.Generate(4, sensorTypes),
                  fullName,
                  idNumber,
                  affiliation)
            {}
        public override bool SupportsCounterAttack() => true;

        public override bool IsAttackNow()
        {
            return TurnCounter > 0 && TurnCounter %3==0 ;
        }
        public override void PerformCounterAttack()
        {
            RemoveBrokenSensors();
            RemoveRandomSensoe(1); 
        }


    }
}
