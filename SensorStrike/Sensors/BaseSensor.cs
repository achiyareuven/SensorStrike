using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SensorStrike.Enums;
using SensorStrike.Agants;
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
        public virtual bool IsAction()
        { return false; }

        public virtual string Action(IranAgent agant)
        {
            return null;
        }
        public virtual bool IsBlockingAttack()=>false;

        public virtual void BlockingAttack() { }







    }
}
