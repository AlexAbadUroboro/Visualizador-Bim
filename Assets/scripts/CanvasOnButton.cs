using UnityEngine;
using UnityEngine.InputSystem; // Nuevo sistema de input
public class CanvasOnButton : MonoBehaviour
{
    public GameObject canvasWorldSpace;
    public float distance = 1.5f;

    // Acción del botón A del mando derecho
    public InputActionProperty rightAButton;

    void Update()
    {
        if (rightAButton.action.WasPressedThisFrame())
        {
            ShowCanvasInFront();
        }
    }

    void ShowCanvasInFront()
    {
        Transform head = Camera.main.transform;

        // Posición frente al usuariod
        canvasWorldSpace.transform.position =
            head.position + head.forward * distance;

        // Rotación mirando al usuariodsfdfffdf
        canvasWorldSpace.transform.LookAt(head);
        canvasWorldSpace.transform.rotation =
            Quaternion.Euler(0, canvasWorldSpace.transform.rotation.eulerAngles.y + 180, 0);

        canvasWorldSpace.SetActive(true);
    }
}