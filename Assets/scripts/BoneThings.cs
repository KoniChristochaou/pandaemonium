using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneThings : MonoBehaviour
{
    public Task thisTask;
    public GameObject[] bones;
    public bool inRange;
    public int state;
    public DistanceScript distanceScript;

    private void Start()
    {
        distanceScript.player = PlayerMovement.pm.gameObject.transform;
        Interactions.instance.onInteract.AddListener(AddBone);
        state = 0;
        UpdateDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        inRange = distanceScript.distance < 0.8f;
    }

    public void AddBone() {
        if (inRange && state< bones.Length && Interactions.instance.hasBone)
        {
            state++;
            Interactions.instance.hasBone = false;
            UpdateDisplay();
        }
    }
    public void RemoveBone()
    {
        if (state>0)
        {
            state--;
            UpdateDisplay();
        }
    }
    void UpdateDisplay() {
        thisTask.completed = state == bones.Length;
        for (int i = 0; i<bones.Length;i++) {
            bones[i].SetActive(i < state);
        }
    }
}
