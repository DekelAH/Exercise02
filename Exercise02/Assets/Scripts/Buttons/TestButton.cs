using Assets.Scripts.Infastructure;
using UnityEngine;

namespace Assets.Scripts.Buttons
{
    public class TestButton : MonoBehaviour
    {
        public void OnTestBtnClick()
        {
            var currentGameConfig = GameConfiguration.ConfingSelectorInstance.CurrentConfig;
            Debug.Log(currentGameConfig.ToString());
        }
    }
}
