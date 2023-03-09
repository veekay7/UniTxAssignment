using System.Collections.Generic;
using UnityEngine;
using SysStopwatch = System.Diagnostics.Stopwatch;

public class Stopwatch : MonoBehaviour
{
    private SysStopwatch m_stopwatch = new SysStopwatch();
    private List<float> m_lapTimes = new List<float>();

    public bool IsRunning { get => m_stopwatch.IsRunning; }

    public float ElapsedTime { get => (float)(m_stopwatch.ElapsedMilliseconds / 1000); }


    /// <summary>
    /// Starts or resumes the stopwatch! You can only start the stopwatch if the stopwatch is running!
    /// </summary>
    public void StartStopwatch()
    {
        if (m_stopwatch.IsRunning)
            return;

        m_stopwatch.Start();
    }


    /// <summary>
    /// You can only stop the stopwatch if it is running. Stoopping the stopwatch pauses it, does not reset to zero.
    /// </summary>
    public void StopStopwatch()
    {
        if (!m_stopwatch.IsRunning)
            return;

        m_stopwatch.Stop();
    }


    /// <summary>
    /// Resets the stopwatch by clearing the laptimes and stops counting. Elapsed time is reset to 0.
    /// This function only works when the stopwatch has paused/stopped.
    /// </summary>
    public void ResetStopwatch()
    {
        if (m_stopwatch.IsRunning)
            return;

        m_lapTimes.Clear();
        m_stopwatch.Reset();
    }


    /// <summary>
    /// Records a lap time. This function onl works when the timer is running!
    /// </summary>
    public void Lap()
    {
        if (!m_stopwatch.IsRunning)
            return;

        m_lapTimes.Add((m_stopwatch.ElapsedMilliseconds / 1000));
        m_stopwatch.Restart();
    }
}
