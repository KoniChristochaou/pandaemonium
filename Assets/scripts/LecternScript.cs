using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LecternScript : MonoBehaviour
{
    public DistanceScript distanceScript;
    public bool isInteractable;
    public bool inRange;
    public GameObject Lectern;
    public float chantTime;
    public float completion;
    private float fill;
    public Image chantTimer;
    
    void Update()
    {
        
        if (distanceScript.distance < 0.8f)
        {
            isInteractable = TaskManager.isAllCompleted();
            inRange = true;
// Lectern.GetComponent<MeshRenderer>().material = Interactable;
        }
        else
        {
            CameraShake.stopShakeIndef();

            inRange = false;
          ///  Lectern.GetComponent<MeshRenderer>().material = unInteractable;
        }
        chantTimer.fillAmount = fill;

        if (!Interactions.interacting || !isInteractable) {
            CameraShake.stopShakeIndef();
        }
    }

   public void interacting()
    {
        if (inRange & isInteractable)
        {
            completion += Time.deltaTime;
            fill = completion / chantTime;
            CameraShake.shakeIndef();
            //Lectern.GetComponent<MeshRenderer>().material = Interacting;
        }
    }
    
}
