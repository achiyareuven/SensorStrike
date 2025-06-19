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
                GameDisplay.PrintNewAgentHeader(_currentAgent.FullName);

                while (!_currentAgent.IsExposed())
                {
                    Menu.ShowMenu();
                    Console.Write("chose sensor: ");
                    string sensorInput = Console.ReadLine();

                    switch(sensorInput)
                    {
                        case "1":
                            _logicGame.Run(_currentAgent, SensorFactory.CreaatSensor(SensorType.Audio));
                            break;
                        case "2":
                            _logicGame.Run(_currentAgent, SensorFactory.CreaatSensor(SensorType.Thermal));
                            break;
                        case "3":
                            _logicGame.Run(_currentAgent, SensorFactory.CreaatSensor(SensorType.Pulse));
                            break;
                        case "4":
                            _logicGame.Run(_currentAgent, SensorFactory.CreaatSensor(SensorType.Motion));
                            break;
                        case "5":
                            _logicGame.Run(_currentAgent, SensorFactory.CreaatSensor(SensorType.Magnetic));
                            break;
                        case "6":
                            _logicGame.Run(_currentAgent, SensorFactory.CreaatSensor(SensorType.Signal));
                            break;
                        case "7":
                            _logicGame.Run(_currentAgent, SensorFactory.CreaatSensor(SensorType.Light));
                            break;
                        default: Console.WriteLine("Invalid input try again");
                            continue;



                    }

                }
                _stageManager.NextAgant();
            }
            GameDisplay.PrintGameOver();

        }



    }
}
