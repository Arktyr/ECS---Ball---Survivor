using System;
using UnityEngine;

namespace Code.Common.MonoHelper
{
    public class MonoBehaviourApplicationHelper : MonoBehaviour
    {
        public event Action<bool> OnApplicationFocused;
        public event Action<bool> OnApplicationPaused;
        public event Action OnApplicationQuited;
        
        private void OnApplicationFocus(bool hasFocus) => 
            OnApplicationFocused?.Invoke(hasFocus);

        private void OnApplicationPause(bool pauseStatus) => 
            OnApplicationPaused?.Invoke(pauseStatus);

        private void OnApplicationQuit() => 
            OnApplicationQuited?.Invoke();
    }
}