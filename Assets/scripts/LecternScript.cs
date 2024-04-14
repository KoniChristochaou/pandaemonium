using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LecternScript : MonoBehaviour
{
    public DistanceScript distanceScript;
    public bool isInteractable;
    public Material unInteractable;
    public Material Interactable;
    public Material Interacting;
    public Material Interacted;
    public GameObject Lectern;

    void Update()
    {
        if (distanceScript.distance < 0.8f)
        {
            isInteractable = true;
            Lectern.GetComponent<MeshRenderer>().material = Interactable;
        }
        else
        {
            isInteractable = false;
            Lectern.GetComponent<MeshRenderer>().material = unInteractable;
        }
    }

    void FixedUpdate()
    {
        if(isInteractable = true && Input.GetButton("Interact"))
        {
            Lectern.GetComponent<MeshRenderer>().material = Interacting;
        }
    }
}
