using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class Interactions : MonoBehaviour
{
    public static bool interacting;
    public UnityEvent onInteract;
    public static Interactions instance;
    public bool hasBone;
    public bool hasRune;
    public GameObject bone;
    public GameObject rune;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
        hasBone = false;
        hasRune = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (interacting) {
            onInteract.Invoke();
        }
        bone.SetActive(hasBone);
        rune.SetActive(hasRune);
    }

    public void Interact(InputAction.CallbackContext ctx) => interacting = ctx.ReadValue<float>()>0f;
}
