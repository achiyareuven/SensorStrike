using System;
using System.Collections.Generic;
using System.Data;
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
                    return new SignalSensor();
                case SensorType.Motion:
                    return new MotionSensor();
                case SensorType.Light:
                    return new LightSensor();
                case SensorType.Pulse:
                    return new PulseSensor();
                case SensorType.Magnetic:
                    return new MagneticSensor();

                default:
                    throw new ArgumentException($"Unknown sensor type: {sensorType}");

            }
        }
    }
}
