using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    List<Task> tsks = new List<Task>();
    public Animator anim;
    public float timeToTroll;
    float timer;
    bool trigger;
    public AudioClip bark;
    // Start is called before the first frame update
    void Start()
    {
        trigger = true;
        timer = 0;
        timeToTroll = Random.Range(5f, 12f);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= timeToTroll && trigger)
        {
            foreach (Task t in TaskManager.tasks)
            {
                if (t.completed)
                {
                    tsks.Add(t);
                }
            }

            if (tsks.Count > 0)
            {
                anim.SetTrigger("doMischief");
                trigger = false;
            }
            else {
                trigger = true;
                timer = 0;
                timeToTroll = Random.Range(5f, 15f);
            }
        }
        timer += Time.deltaTime;
    }

    public void doMisdeeds() {
        tsks[Random.Range(0, tsks.Count)].doMischeif();
        AudioSource.PlayClipAtPoint(bark, this.transform.position);
        anim.ResetTrigger("doMischief");
        trigger = true;
        timer = 0;
        timeToTroll = Random.Range(5f, 12f);
    }
}
