using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SensorStrike.Enums;

namespace SensorStrike.Sensors
{
    public class PulseSensor : BaseSensor
    {
        private int _activation = 3;

        public PulseSensor() : base(SensorType.Pulse) { }

        public override void Activate()
        {
            _activation--;
            Console.WriteLine($"attttt left {_activation}");
        }
        public override bool HasEffect()
        {
            return _activation > 0;
        }
    }
}
