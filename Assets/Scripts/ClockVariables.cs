using System;
using UnityEngine;

[CreateAssetMenu(fileName = "ClockVariables", menuName = "Assignment/ClockIntermediate")]
public class ClockVariables : ScriptableObject
{
    private DateTime m_curDateTime;
    private TimeZoneInfo m_timezone;

    public DateTime CurrentDateTime { get => m_curDateTime; }

    public TimeZoneInfo CurrentTimeZone { get => m_timezone; }


    public void SetDateTime(DateTime dateTime)
    {
        m_curDateTime = dateTime;
    }

    
    public void SetTimeZone(TimeZoneInfo newTimeZone)
    {
        m_timezone = newTimeZone;
    }
}
