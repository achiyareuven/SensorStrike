using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SensorStrike.Enums;

namespace SensorStrike.Sensors
{
    public class MagneticSensor: BaseSensor
    {
        private int _blockLeft = 2;

        public MagneticSensor() : base(SensorType.Magnetic) { }

        public override void BlockingAttack()
        {
            if (_blockLeft > 0) _blockLeft--;
        }
        public override bool IsBlockingAttack() => _blockLeft > 0; 

    }
}
