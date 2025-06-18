using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SensorStrike.Enums;
using SensorStrike.Sensors;
using SensorStrike.halper;

namespace SensorStrike.Agants
{
    public class FootSoldier : IranAgent
    {
        private static SensorType[] sensorType = new[]
        {
            SensorType.Thermal,
            SensorType.Audio
        };
        public FootSoldier(string fullName, string idNumber, string affiliation) : base
        (
        AgentRank.FootSoldier,
        RandomSensor.Generate(2, sensorType),
        fullName,
        idNumber,
        affiliation)
        {}
        public override bool SupportsCounterAttack() => false;

        public override bool IsAttackNow() => false;

        public override void PerformCounterAttack() { }

    }
}
