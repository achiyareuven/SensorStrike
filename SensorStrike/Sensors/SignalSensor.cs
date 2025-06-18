using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SensorStrike.Agants;
using SensorStrike.Enums;

namespace SensorStrike.Sensors
{
    public class SignalSensor : BaseSensor
    {
        public SignalSensor() : base(SensorType.Signal) { }


        public override bool IsAction() => true;

        public override string Action(IranAgent agent)
        {
            return $" Signal sensor revealed: Agent Rank = {agent.Rank}";
        }


    }
}
