using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeAOnes : MonoBehaviour
{

    public GameObject[] objs;

    private Queue<GameObject> skittle;

    public void MultStart()
    {
        skittle = new Queue<GameObject>();

        foreach (GameObject obj in objs)
        {
            obj.SetActive(false);
            skittle.Enqueue(obj);

        }
    }
    public void MultClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            skittle.Dequeue().SetActive(true);
        }
    }

}
