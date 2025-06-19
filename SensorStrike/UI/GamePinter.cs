using System;
using System.Collections.Generic;
using SensorStrike.Agants;
using SensorStrike.Sensors;

namespace SensorStrike.UI
{
    public static class GameDisplay
    {
        public static void PrintNewAgentHeader(string fullName)
        {
            Console.WriteLine("=====================================================================");
            Console.WriteLine($"                 Starting Investigation: {fullName}");
            Console.WriteLine("====================================================================\n");
        }
        public static void PrintWeaknesses(List<Enums.SensorType> weaknesses)
        {
            Console.WriteLine("\n==== Agent Weaknesses======");
            foreach (var w in weaknesses)
                Console.WriteLine($"- {w}");
            Console.WriteLine();
        }

        public static void PrintAttachedSensors(List<ISensor> sensors)
        {
            Console.WriteLine("===== Attached Sensors======:");
            foreach (var s in sensors)
            {
                Console.WriteLine($"-{s.Type}");
            }
            Console.WriteLine();
        }

        public static void PrintMatches(int matches, int total)
        {
            Console.WriteLine($" Sensor Matches: {matches}/{total}\n");
        }

        public static void PrintBlockedAttack()
        {
            Console.WriteLine(" Sensor blocked the counterattack.\n");
        }

        public static void PrintCounterAttack()
        {
            Console.WriteLine(" Agent performed a counterattack!\n");
        }

        public static void PrintSensorAction(string message)
        {
            Console.WriteLine($" Sensor Action: {message}\n");
        }

        public static void PrintSensorBroken(ISensor sensor)
        {
            Console.WriteLine($"Sensor {sensor.Type} is now broken!\n");
        }

        public static void PrintAgentExposed(string agentName)
        {
            Console.WriteLine($" Agent {agentName} has been exposed!\n");
        }

        public static void PrintTurnSeparator()
        {
            Console.WriteLine("\n                               ================= NEW TURN =================\n");
        }
        public static void PrintGameOver()
        {
            Console.WriteLine("\n Game Over! All agents have been exposed.");
        }

    }
}
