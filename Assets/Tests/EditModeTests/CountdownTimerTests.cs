using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CountdownTimerTests
{
    public const long k_MillisecondsPerMin = 60000;                              // 1 minute has 60000 milliseconds.
    public const long k_MillisecondsPerSecond = 1000;                            // 1 second has 1000 milliseconds.

    public const long k_CountdownRangeMin = (1 * k_MillisecondsPerMin);          // Countdown timer min time = 1 minute (60 secs).
    public const long k_CountdownRangeMax = (60 * k_MillisecondsPerMin);         // Countdown timer max time = 60 minutes (3600 secs).

    public static uint MillisecondsToMinutes(long ms) { return (uint)(ms / k_MillisecondsPerMin); }

    public static long MinutesToMilliseconds(long min) { return min * k_MillisecondsPerMin; }

    public static float MillisecondsToSeconds(long ms) { return ms / k_MillisecondsPerSecond; }

    public static long SecondsToMilliseconds(float sec) { return (long)(sec * k_MillisecondsPerSecond); }


    [Test]
    public void TestTimeConversions()
    {
        Debug.LogFormat("10 minutes = {0} ms", MinutesToMilliseconds(10));
        Debug.LogFormat("{0} seconds = {1} ms", Time.deltaTime, SecondsToMilliseconds(Time.deltaTime));
    }

    [Test]
    public void TestStartTimeSetting()
    {
        Debug.LogFormat("Start time 60 minutes = {0} ms", SetStartTime(60));
    }

    [UnityTest]
    public IEnumerator Co_TestCountdown()
    {
        yield return null;
    }

    private long SetStartTime(uint startTimeMins)
    {
        long startTime = MinutesToMilliseconds(startTimeMins);
        if (startTime <= k_CountdownRangeMin)
            startTime = k_CountdownRangeMin;
        else if (startTime >= k_CountdownRangeMax)
            startTime = k_CountdownRangeMax;

        return startTime;
    }
}
