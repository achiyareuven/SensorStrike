using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SensorStrike.Agants;
using SensorStrike.Sensors;
using SensorStrike.UI;

namespace SensorStrike.Game
{
    public class LogicGame
    {
        public void Run(IranAgent agent, ISensor sensor)
        {
            GameDisplay.PrintTurnSeparator();

            if (agent.Weaknesses.Contains(sensor.Type))
            {
                agent.AddSensor(sensor);
            }

            foreach (var s in agent.AttachedSensors)
            {
                s.Activate();
                if (!s.HasEffect()) GameDisplay.PrintSensorBroken(s);
            }

            agent.setTurn();
            agent.RemoveBrokenSensors();

            GameDisplay.PrintAttachedSensors(agent.AttachedSensors);

            int matches = agent.CountMatchingSensors();
            GameDisplay.PrintMatches(matches, agent.Weaknesses.Count);

            if (agent.IsExposed())
            {
                GameDisplay.PrintAgentExposed(agent.FullName);
                return;
            }

            if (agent.SupportsCounterAttack() && agent.IsAttackNow())
            {
                var sensorBlock = agent.AttachedSensors
                    .OfType<BaseSensor>()
                    .FirstOrDefault(s => s.IsBlockingAttack() && agent.Weaknesses.Contains(s.Type));

                if (sensorBlock != null)
                {
                    sensorBlock.BlockingAttack();
                    GameDisplay.PrintBlockedAttack();
                }
                else
                {
                    agent.PerformCounterAttack();
                    GameDisplay.PrintCounterAttack();
                }
            }

            if (sensor is BaseSensor sen && sen.IsAction())
            {
                string info = sen.Action(agent);
                if (!string.IsNullOrWhiteSpace(info))
                    GameDisplay.PrintSensorAction(info);
            }
        }


    }
}
