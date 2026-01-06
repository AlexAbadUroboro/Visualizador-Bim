using UnityEngine;
using UnityEngine.InputSystem;

public class SimpleFly_PosY : MonoBehaviour
{
    private InputSystem_Actions actions;
    private InputAction previousAction;
    private InputAction nextAction;

    [Header("Configuración")]
    public float speed = 2f; // metros por segundo

    private void Awake()
    {
        actions = new InputSystem_Actions();
        previousAction = actions.Player.Previous;
        nextAction = actions.Player.Next;
    }

    private void OnEnable()
    {
        previousAction.Enable();
        nextAction.Enable();
    }

    private void OnDisable()
    {
        previousAction.Disable();
        nextAction.Disable();
    }

    private void Update()
    {
        float prev = previousAction.ReadValue<float>(); // 0 o 1
        float nx = nextAction.ReadValue<float>();     // 0 o 1

        // next = +1 (subir)
        // previous = -1 (bajar)
        float direction = nx - prev;

        if (direction != 0)
        {
            transform.position += Vector3.up * direction * speed * Time.deltaTime;
        }
    }
}
