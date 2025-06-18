using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SensorStrike.Agants;
using SensorStrike.Enums;
using SensorStrike.UI;
using SensorStrike.Factorys;


namespace SensorStrike.Game
{
    public class GameManager
    {
        private StageManager _stageManager = new StageManager() ;
        private  LogicGame _logicGame = new LogicGame();
        private IranAgent _currentAgent;

        public void Start()
        {
            while (_stageManager.HasMoreStages())
            {
                _currentAgent = _stageManager.GetCurrentAgent();
                Console.WriteLine($"            New Agent Investigation {_currentAgent.FullName}");
                while (!_currentAgent.IsExposed())
                {
                    Menu.ShowMenu();
                    Console.WriteLine("chose sensor;");
                    string sensorInput = Console.ReadLine();
                    switch(sensorInput)
                    {
                        case "1":
                            _logicGame.Run(_currentAgent, SensorFactory.CreaatSensor(SensorType.Audio));
                            break;
                        case "2":
                            _logicGame.Run(_currentAgent, SensorFactory.CreaatSensor(SensorType.Thermal));
                            break;
                        default: Console.WriteLine("Invalid input");
                            continue;



                    }

                }
                Console.WriteLine(" Agent exposed!");
                _stageManager.NextAgant();
            }
            Console.WriteLine("game over");

        }



    }
}
