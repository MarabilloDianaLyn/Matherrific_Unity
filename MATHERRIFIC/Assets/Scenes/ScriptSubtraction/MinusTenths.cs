using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinusTenths : MonoBehaviour
{

    public GameObject[] objs;

    private Queue<GameObject> tenths;

    public void Start6()
    {
        tenths = new Queue<GameObject>();

        foreach (GameObject obj in objs)
        {
            obj.SetActive(false);
            tenths.Enqueue(obj);

        }
    }
    public void MinusTenthClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            tenths.Dequeue().SetActive(true);
        }
    }

}
