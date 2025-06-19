using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SensorStrike.Enums;

namespace SensorStrike.halper
{
    internal class RandomSensor
    {
        public static List<SensorType> Generate(int count, SensorType[] sensorsType)
        {
            var result = new List<SensorType>();
            var random = new Random();

            for (int i = 0; i < count; i++)
            {
                var chosen = sensorsType[random.Next(sensorsType.Length)];
                result.Add(chosen);
            }

            return result;
        }
    }
}
