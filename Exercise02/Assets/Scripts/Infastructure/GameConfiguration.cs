using Assets.Scripts.Models;
using UnityEngine;

namespace Assets.Scripts.Infastructure
{
    public sealed class GameConfiguration
    {

        #region Fields

        private static GameConfiguration _gameConfigInstance;

        private static ConfigurationSelector _configSelector;

        private const string CONFIG_SELECTOR_RESOURCE_NAME = "Configuration Selector";

        #endregion

        #region Constructors

        private GameConfiguration(string confingSelectorResourceName)
        {
            _configSelector = Resources.Load<ConfigurationSelector>(confingSelectorResourceName);
        }

        #endregion

        #region Properties

        public static GameConfiguration ConfingSelectorInstance
        {
            get
            {
                if (_gameConfigInstance == null)
                {
                    _gameConfigInstance = new GameConfiguration(CONFIG_SELECTOR_RESOURCE_NAME);
                }

                return _gameConfigInstance;
            }
        }

        public EnvironmentParams CurrentConfig => _configSelector.GetCurrentConfig();

        #endregion
    }
}
