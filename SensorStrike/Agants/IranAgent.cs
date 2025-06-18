using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SensorStrike.Enums;
using SensorStrike.Sensors;
using SensorStrike.halper;

namespace SensorStrike.Agants
{
     public abstract class IranAgent
     {
        public int Id { get; set; }
        public AgentRank Rank { get; protected set; }
        public List<SensorType> Weaknesses { get; protected set; }
        public List<ISensor> AttachedSensors { get; protected set; } = new List<ISensor> ();
        public string FullName { get; protected set; }
        public string IdNumber { get; protected set; }
        public string Affiliation { get; protected set; }
        public int TurnCounter { get; protected set; } = 0;
        public IranAgent(AgentRank rank, List<SensorType> weaknesses, string fullName, string idNumber, string affiliation)
        {
            Rank = rank;
            this.Weaknesses = weaknesses;
            FullName = fullName;
            IdNumber = idNumber;
            Affiliation = affiliation;
        }
        public void setTurn()
        {
            TurnCounter++;
        }

        public void AddSensor(ISensor sensor)
        {
            AttachedSensors.Add(sensor);
            
        }
        public int CountMatchingSensors()
        {
            var required = Weaknesses
                .GroupBy(w => w)
                .ToDictionary(g => g.Key, g => g.Count());

            int matchCount = 0;

            foreach (var sensor in AttachedSensors)
            {
              //  sensor.Activate();
                if (!sensor.HasEffect()) continue;

                if (required.ContainsKey(sensor.Type) && required[sensor.Type] > 0)
                {
                    required[sensor.Type]--;
                    matchCount++;
                }
            }

            return matchCount;
        }

        public bool IsExposed() => CountMatchingSensors() == Weaknesses.Count;


        public abstract bool SupportsCounterAttack();

        public abstract bool IsAttackNow();

        public abstract void PerformCounterAttack();


        protected void RemoveRandomSensoe(int count)
        {
            Random rand = new Random();
            for (int i = 0; i < count && i <AttachedSensors.Count; i++)
            {
                int index = rand.Next(AttachedSensors.Count);
                AttachedSensors.RemoveAt(index);
            }
        }
        protected void RemoveBrokenSensors()
        {
            AttachedSensors.RemoveAll(sensor => !sensor.HasEffect());
        }


    }
}
