using System;

namespace Code.Common.Time
{
    public interface ITimeService
    {
        DateTime UtcNow { get; }
        float DeltaTime { get; }
        float LifeTimeInSeconds { get; }
        float LifeTimeInMinutes { get; }
        float LifeTimeInHours { get; }
        void SetTimeScale(float value);
    }
}