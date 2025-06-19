using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SensorStrike.Agants;
using SensorStrike.Enums;

namespace SensorStrike.Sensors
{
    class MotionSensor : BaseSensor
    {
        public MotionSensor() : base(SensorType.Motion) { }

        public override bool IsAction()
        {
            return true;
        }
        public override string Action(IranAgent agant)
        {
            if (!agant.Weaknesses.Contains(this.Type)) return null;
            Random random= new Random();
            int index = random.Next(agant.Weaknesses.Count);
            return $"Motion Sensor revealed one corect weaknes: {agant.Weaknesses[index]}";
        }
    }
}
