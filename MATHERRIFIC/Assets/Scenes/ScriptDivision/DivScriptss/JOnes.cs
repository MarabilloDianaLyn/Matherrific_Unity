using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JOnes : MonoBehaviour
{

    public GameObject[] objs;

    private Queue<GameObject> ones;

    public void StartOnesJ()
    {
        ones = new Queue<GameObject>();

        foreach (GameObject obj in objs)
        {
            obj.SetActive(false);
            ones.Enqueue(obj);

        }
    }
    public void VideOnesJ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ones.Dequeue().SetActive(true);
        }
    }

}
