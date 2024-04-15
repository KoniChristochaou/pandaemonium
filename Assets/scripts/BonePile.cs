using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BonePile : MonoBehaviour
{
    public DistanceScript distanceScript;
    public bool inRange;
    public float timeToGetBone;
    private float boneTime;
    public Image loading;
    private void Start()
    {
        distanceScript.player = PlayerMovement.pm.gameObject.transform;
        Interactions.instance.onInteract.AddListener(AddBone);
    }

    // Update is called once per frame
    void Update()
    {
        inRange = distanceScript.distance < 0.8f;
        loading.gameObject.SetActive(inRange);
        if (!inRange) {
            boneTime = 0;
        }
        loading.fillAmount = boneTime / timeToGetBone;
    }

    public void AddBone() {
        if (inRange && !Interactions.instance.hasBone && !Interactions.instance.hasRune) {
            if (boneTime >= timeToGetBone)
            {
                boneTime = 0;
                Interactions.instance.hasBone = true;
                return;
            }
            boneTime += Time.deltaTime;
        }
    }
}
