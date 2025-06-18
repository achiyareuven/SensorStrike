using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SensorStrike.Agants;
using SensorStrike.Sensors;

namespace SensorStrike.Game
{
    public class LogicGame
    {
        public void Run(IranAgent agant ,ISensor sensor)
        {
            agant.AddSensor(sensor);
            int matches =agant.CountMatchingSensors();
            Console.WriteLine($"your sensor matches:{matches}");
            

            if (agant.SupportsCounterAttack() && agant.IsAttackNow())
            {
                agant.PerformCounterAttack();
                Console.WriteLine("Agant attack");
            }
            if (sensor is BaseSensor sen && sen.IsAction())
            {
                    string info = sen.Action(agant);
                    Console.WriteLine(info);
                
            }
            bool exposed = agant.IsExposed();
            if (exposed)
            {
                Console.WriteLine($"agant {agant.FullName} is exposed");
            }

        }
    }
}
