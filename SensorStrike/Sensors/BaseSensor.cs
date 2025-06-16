using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SensorStrike.Enums;

namespace SensorStrike.Sensors
{
    public class BaseSensor : ISensor
    {
        public SensorType Type { get; private set; }

        public BaseSensor(SensorType type)
        {
            Type = type;
        }

        public virtual void Activate()
        {
        }

        public virtual bool HasEffect()
        {
            return true; 
        }

        public virtual ISensor Clone()
        {
            return new BaseSensor(this.Type);
        }
    }
}
