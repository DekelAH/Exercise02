using UnityEngine;

namespace Assets.Scripts.Models
{
    [CreateAssetMenu(menuName = "Exercise02/Models/Environment Params", fileName = "Environment Params")]
    public class EnvironmentParams : ScriptableObject
    {
        #region Editor

        [SerializeField]
        private string _serverAddress;

        [SerializeField]
        private string _logPrefix;

        [SerializeField]
        private float _serverTimeOut;

        [SerializeField]
        private int _gameVersion;

        #endregion

        #region Properties

        public string ServerAddress => _serverAddress;
        public string LogPrefix => _logPrefix;
        public float ServerTimeOut => _serverTimeOut;
        public int GameVersion => _gameVersion;

        #endregion
    }
}
