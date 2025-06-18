using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SensorStrike.Agants;
using SensorStrike.Enums;

namespace SensorStrike.Sensors
{
    public class LightSensor : BaseSensor
    {
        public LightSensor():  base(SensorType.Light) { }

        public override bool IsAction()
        {
            return true;
        }
        public override string Action(IranAgent agant)

        {   
            if (agant.Weaknesses.Contains(this.Type))
            { 
                return $" Light sensor revealed: Agent Rank : {agant.Rank}" +
                 $":Agant affiliation : {agant.Affiliation}";
            }
            return null ;
        }
    }
}
