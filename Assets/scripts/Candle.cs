using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candle : MonoBehaviour
{
    public Task thisTask;
    public GameObject flame;
    public bool inRange;
    public DistanceScript distanceScript;

    private void Start()
    {
        distanceScript.player = PlayerMovement.pm.gameObject.transform;
        Interactions.instance.onInteract.AddListener(LightCandle);
        PutOutCandle();
    }
    private void Update()
    {
            inRange = distanceScript.distance < 0.8f;
    }
    public void LightCandle() {
        if (inRange)
        {
            thisTask.completed = true;
            flame.SetActive(true);
        }
    }

    public void PutOutCandle()
    {
        thisTask.completed = false;
        flame.SetActive(false);
    }
}

