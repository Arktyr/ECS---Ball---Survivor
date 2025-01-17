using UnityEngine;

namespace Code.Common.DontDestroy
{
    public class DontDestroyObject : MonoBehaviour
    {
        private void Awake() => 
            DontDestroyOnLoad(this);
    }
}