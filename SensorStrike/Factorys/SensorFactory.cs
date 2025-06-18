using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SensorStrike.Enums;
using SensorStrike.Sensors;

namespace SensorStrike.Factorys
{
    public static class SensorFactory
    {
        public static ISensor CreaatSensor(SensorType sensorType)
        {
            switch(sensorType)
            {
                case SensorType.Audio:
                    return new BaseSensor(SensorType.Audio);
                case SensorType.Thermal:
                    return new BaseSensor(SensorType.Thermal);
                case SensorType.Signal:
                    return new BaseSensor(SensorType.Signal);
                case SensorType.Motion:
                    return new BaseSensor(SensorType.Motion);
                case SensorType.Light:
                    return new BaseSensor(SensorType.Light);
                case SensorType.Pulse:
                    return new BaseSensor(SensorType.Pulse);

                default: return null;

            }
        }
    }
}
