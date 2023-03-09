using System;
using System.Collections.ObjectModel;
using UnityEngine;

public class Clock : MonoBehaviour
{
    private ReadOnlyCollection<TimeZoneInfo> m_timezones;
    private TimeZoneInfo m_curTimeZone;

    public ReadOnlyCollection<TimeZoneInfo> TimeZones { get => m_timezones; }


    private void Awake()
    {  
        m_timezones = TimeZoneInfo.GetSystemTimeZones();
        SetTimeZone(TimeZoneInfo.Local);
    }


    private void Start()
    {
        // Find the local timezone of this system and set the time.
        SetTimeZone(TimeZoneInfo.Local);
    }


    public DateTime GetLocalDateTime()
    {
        DateTime utcTime = DateTime.UtcNow;
        DateTime newLocalTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(utcTime, m_curTimeZone.Id);
        return newLocalTime;
    }


    public void SetTimeZone(TimeZoneInfo newTimeZone)
    {
        m_curTimeZone = newTimeZone;
    }
}
