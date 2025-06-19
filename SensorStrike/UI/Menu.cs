using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SensorStrike.Enums;

namespace SensorStrike.UI
{
    public static class Menu
    {
        public  static void ShowMenu()
        {
            Console.WriteLine($"1: {SensorType.Audio}");
            Console.WriteLine($"2: {SensorType.Thermal}");
            Console.WriteLine($"3: {SensorType.Pulse}");
            Console.WriteLine($"4: {SensorType.Motion}");
            Console.WriteLine($"5: {SensorType.Magnetic}");
            Console.WriteLine($"6: {SensorType.Signal}");
            Console.WriteLine($"7: {SensorType.Light}");
            Console.WriteLine();
        }
    }
}
