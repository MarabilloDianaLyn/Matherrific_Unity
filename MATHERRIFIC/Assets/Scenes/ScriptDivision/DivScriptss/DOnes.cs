using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DOnes : MonoBehaviour
{

    public GameObject[] objs;

    private Queue<GameObject> ones;

    public void StartOnesD()
    {
        ones = new Queue<GameObject>();

        foreach (GameObject obj in objs)
        {
            obj.SetActive(false);
            ones.Enqueue(obj);

        }
    }
    public void VideDOnes()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ones.Dequeue().SetActive(true);
        }
    }

}
