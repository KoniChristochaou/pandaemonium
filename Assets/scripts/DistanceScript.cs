using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceScript : MonoBehaviour
{
    public Transform player;
    public Transform self;
    public float distance;

    void Update()
    {
        distance = Vector3.Distance(player.transform.position, self.transform.position);
    }
}
