using UnityEngine;
using UnityEngine.InputSystem;

public class ToggleCanvas : MonoBehaviour
{
    public GameObject canvasToToggle;

    private InputSystem_Actions inputActions;
    private bool isVisible = true;

    private void Awake()
    {
        inputActions = new InputSystem_Actions();
    }

    private void OnEnable()
    {
        inputActions.Enable();
        inputActions.Player.Interact.performed += OnInteract;
    }

    private void OnDisable()
    {
        inputActions.Player.Interact.performed -= OnInteract;
        inputActions.Disable();
    }

    private void OnInteract(InputAction.CallbackContext ctx)
    {
        isVisible = !isVisible;
        canvasToToggle.SetActive(isVisible);
    }
}
