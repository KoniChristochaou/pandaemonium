using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rock : MonoBehaviour
{
    public DistanceScript distanceScript;
    public bool inRange;
    public float timeToGetRune;
    private float runeTime;
    public Image loading;
    private void Start()
    {
        distanceScript.player = PlayerMovement.pm.gameObject.transform;
        Interactions.instance.onInteract.AddListener(AddRune);
    }

    // Update is called once per frame
    void Update()
    {
        inRange = distanceScript.distance < 0.8f;
        loading.gameObject.SetActive(inRange);
        if (!inRange)
        {
            runeTime = 0;
        }
        loading.fillAmount = runeTime / timeToGetRune;
    }

    public void AddRune()
    {
        if (inRange && !Interactions.instance.hasBone && !Interactions.instance.hasRune)
        {
            if (runeTime >= timeToGetRune)
            {
                runeTime = 0;
                Interactions.instance.hasRune = true;
                return;
            }
            runeTime += Time.deltaTime;
        }
    }
}
