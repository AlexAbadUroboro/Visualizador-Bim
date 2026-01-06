using UnityEngine;
using UnityEngine.UI;

public class TurnOffToggleOnActivate : MonoBehaviour
{
    [Tooltip("Toggle que se apagará al activarse este objeto")]
    [SerializeField] private Toggle targetToggle;

    private void OnEnable()
    {
        if (targetToggle != null)
        {
            // Solo cambia si está encendido, para evitar loops
            if (targetToggle.isOn)
            {
                targetToggle.isOn = false; // ✅ DISPARA OnValueChanged
            }
        }
        else
        {
            Debug.LogWarning($"{name}: No hay Toggle asignado.");
        }
    }
}
