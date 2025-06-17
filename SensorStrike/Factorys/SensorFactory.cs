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
                default: return null;

            }
        }
    }
}
