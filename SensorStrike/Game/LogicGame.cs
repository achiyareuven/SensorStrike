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
            Console.WriteLine();
            if (agant.Weaknesses.Contains(sensor.Type))  sensor.Activate();
            foreach (var sebsor in agant.AttachedSensors)  sensor.Activate(); 

            agant.setTurn();

            if (agant.Weaknesses.Contains(sensor.Type))
            {
                agant.AddSensor(sensor);
            }
     
            int matches =agant.CountMatchingSensors();
            Console.WriteLine($"your sensor matches:{matches}");

            if (agant.IsExposed()) return;
            

            if (agant.SupportsCounterAttack() && agant.IsAttackNow())
            {
                var sensorBlock = agant.AttachedSensors.OfType<BaseSensor>().FirstOrDefault(sens => sens.IsBlockingAttack());
                if (sensorBlock != null && agant.Weaknesses.Contains(sensorBlock.Type)) 
                {
                    sensorBlock.BlockingAttack();
                    Console.WriteLine($"your sensor blocked attack");
                }
                else
                {
                    agant.PerformCounterAttack();
                    Console.WriteLine("Agant attack");

                }
            }
            if (sensor is BaseSensor sen && sen.IsAction())
            {
                string info = sen.Action(agant);
                if (info!=null)
                {
                    
                    Console.WriteLine(info);
                }
                
            }
            bool exposed = agant.IsExposed();
         

        }
    }
}
