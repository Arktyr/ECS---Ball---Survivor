using System;
using Code.Common.GameControl;
using Code.Common.GameControl.Provider;
using UnityEngine;
using Zenject;

namespace Code.Common.Time
{
    public class TimeService : ITickable, ITimeService
    {
        private readonly IGameStatusProvider _gameStatusProvider;
        
        private float _gameLifeTimeInSecondsTotal;

        public TimeService(IGameStatusProvider gameStatusProvider)
        {
            _gameStatusProvider = gameStatusProvider;
        }

        public DateTime UtcNow => DateTime.UtcNow;
        public float DeltaTime => UnityEngine.Time.deltaTime;

        public float LifeTimeTotal => _gameLifeTimeInSecondsTotal;
        public float LifeTimeInSeconds => Mathf.Ceil(_gameLifeTimeInSecondsTotal);
        public float LifeTimeInMinutes => LifeTimeInSeconds / 60;
        public float LifeTimeInHours => LifeTimeInMinutes / 60;

        public void SetTimeScale(float value)
        {
            var clampValue = Mathf.Clamp(value, 0, Single.PositiveInfinity);
            
            UnityEngine.Time.timeScale = clampValue;
        }

        public void Tick()
        {
            if (_gameStatusProvider.GameStatus == GameStatus.Pause)
                return;

            _gameLifeTimeInSecondsTotal += UnityEngine.Time.deltaTime;
        }
    }
}