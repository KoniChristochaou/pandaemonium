using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Task : MonoBehaviour
{
    public bool completed;
    public UnityEvent Mischiefs;
    // Start is called before the first frame update
    void Start()
    {
        TaskManager.tasks.Add(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void doMischeif() {
        Mischiefs.Invoke();
    }
}
