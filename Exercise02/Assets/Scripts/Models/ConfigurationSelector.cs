using UnityEngine;

namespace Assets.Scripts.Models
{
    [CreateAssetMenu(menuName = "Exercise02/Models/Configuration Selector", fileName = "Configuration Selector")]
    public class ConfigurationSelector : ScriptableObject
    {
        #region Editor

        [SerializeField]
        private EnvironmentType _environmentType;

        [SerializeField]
        private EnvironmentParams _productionParams;

        [SerializeField]
        private EnvironmentParams _developmentParams;

        [SerializeField]
        private EnvironmentParams _qaParams;

        #endregion

        #region Methods

        public EnvironmentParams GetCurrentConfig()
        {
            switch (_environmentType)
            {
                case EnvironmentType.Production:
                    return _productionParams;
                case EnvironmentType.Development:
                    return _developmentParams;
                case EnvironmentType.QA:
                    return _qaParams;
                default:
                    return null;
            }
        }

        #endregion
    }
}
