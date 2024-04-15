using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Altar : MonoBehaviour
{
    public Task thisTask;
    public GameObject rune;
    public bool inRange;
    public DistanceScript distanceScript;

    private void Start()
    {
        distanceScript.player = PlayerMovement.pm.gameObject.transform;
        Interactions.instance.onInteract.AddListener(placeRune);
        removeRune();
    }
    private void Update()
    {
        inRange = distanceScript.distance < 0.8f;
    }
    public void placeRune()
    {
        if (inRange && Interactions.instance.hasRune)
        {
            thisTask.completed = true;
            rune.SetActive(true);
            Interactions.instance.hasRune = false;
        }
    }

    public void removeRune()
    {
        thisTask.completed = false;
        rune.SetActive(false);
    }
}
