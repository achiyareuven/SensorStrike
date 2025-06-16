using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SensorStrike.Enums;

namespace SensorStrike.Sensors
{
    public interface ISensor
    {
        SensorType Type { get; }

        void Activate();

        bool HasEffect();

        ISensor Clone();
    }
}
