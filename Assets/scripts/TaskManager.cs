using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskManager : MonoBehaviour
{

    public static List<Task> tasks = new List<Task>();
    public static bool isAllCompleted() {
        foreach (Task t in tasks) {
            if (!t.completed)
            {
                return false;
            }
        }
        return true;
    }
}
