using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task : MonoBehaviour
{
    public bool completed;
    // Start is called before the first frame update
    void Start()
    {
        TaskManager.tasks.Add(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
