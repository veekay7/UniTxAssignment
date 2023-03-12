using TMPro;
using UnityEngine;

public class UITimezoneText : MonoBehaviour
{
    [SerializeField]
    private TMP_Text m_textComponent;
    [SerializeField]
    private ClockVariables m_clockVariables = null;


    private void Awake()
    {
        if (m_textComponent == null)
            m_textComponent = GetComponent<TMP_Text>();
    }


    private void LateUpdate()
    {
        if (m_textComponent != null && m_clockVariables != null)
        {
            m_textComponent.text = m_clockVariables.CurrentTimeZone.DisplayName;
        }
    }
}
