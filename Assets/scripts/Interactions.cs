using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class Interactions : MonoBehaviour
{
    public bool interacting;
    public UnityEvent onInteract;
    public static Interactions instance;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (interacting) {
            onInteract.Invoke();
        }
    }

    public void Interact(InputAction.CallbackContext ctx) => interacting = ctx.ReadValue<float>()>0f;
}
