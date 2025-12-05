using UnityEngine;
using UnityEngine.InputSystem;

public class CanvasOnButtonPress : MonoBehaviour
{
    public InputActionProperty buttonAction;   // ← aquí va tu Input Action
    public GameObject canvasWorldSpace;
    public float distance = 1.5f;

    void Update()
    {
        if (buttonAction.action != null && buttonAction.action.WasPressedThisFrame())
        {
            ShowCanvasInFront();
        }
    }

    void ShowCanvasInFront()
    {
        Transform head = Camera.main.transform;

        canvasWorldSpace.transform.position = head.position + head.forward * distance;

        canvasWorldSpace.transform.LookAt(head);
        canvasWorldSpace.transform.rotation = Quaternion.Euler(
            0,
            canvasWorldSpace.transform.rotation.eulerAngles.y + 180,
            0
        );

        canvasWorldSpace.SetActive(true);
    }
}
