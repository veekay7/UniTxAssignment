using TMPro;
using UnityEngine;

public class UIClockText : MonoBehaviour
{
    [SerializeField]
    private ClockVariables m_clockVariables = null;
    [SerializeField]
    private bool m_timeFormat24Hour = false;
    [SerializeField]
    private TMP_Text m_textComponent = null;

    public bool TimeIn24HourFormat 
    { 
        get => m_timeFormat24Hour; 
        set => m_timeFormat24Hour = value; 
    }


    private void Awake()
    {
        if (m_textComponent == null)
            m_textComponent = GetComponent<TMP_Text>();
    }


    private void LateUpdate()
    {
        if (m_textComponent != null && m_clockVariables != null)
        {
            if (m_timeFormat24Hour)
                m_textComponent.text = m_clockVariables.CurrentDateTime.ToString("HH:mm:ss");
            else
                m_textComponent.text = m_clockVariables.CurrentDateTime.ToString("hh:mm:ss tt");
        }
    }
}
