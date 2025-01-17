using System;
using Code.Common.GameControl.Provider;
using Code.Common.MonoHelper;
using UnityEngine;

namespace Code.Common.GameControl
{
    public class GameControlService : IGameControlService, IDisposable
    {
        private readonly IGameStatusProvider _gameStatusProvider;
        private readonly MonoBehaviourApplicationHelper _monoBehaviourApplicationHelper;

        public GameControlService(IGameStatusProvider gameStatusProvider, 
            MonoBehaviourApplicationHelper monoBehaviourApplicationHelper)
        {
            _gameStatusProvider = gameStatusProvider;
            _monoBehaviourApplicationHelper = monoBehaviourApplicationHelper;
        }

        public void Initialize()
        {
            _monoBehaviourApplicationHelper.OnApplicationPaused += OnApplicationPaused;
            _monoBehaviourApplicationHelper.OnApplicationQuited += StopGame;
        }

        public void StartGame()
        {
            Debug.Log("Play");
            _gameStatusProvider.SetGameStatus(GameStatus.Play);
        }

        public void StopGame()
        {
            Debug.Log("Stop");
            _gameStatusProvider.SetGameStatus(GameStatus.Pause);
        }

        private void OnApplicationPaused(bool flag) => 
            StopGame();

        public void Dispose()
        {
            _monoBehaviourApplicationHelper.OnApplicationPaused -= OnApplicationPaused;
            _monoBehaviourApplicationHelper.OnApplicationQuited -= StopGame;
        }
    }
}