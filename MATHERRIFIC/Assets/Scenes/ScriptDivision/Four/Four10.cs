using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Four10 : MonoBehaviour
{

    public GameObject[] objs;

    private Queue<GameObject> ten;

    public void Start21()
    {
        ten = new Queue<GameObject>();

        foreach (GameObject obj in objs)
        {
            obj.SetActive(false);
            ten.Enqueue(obj);

        }
    }
    public void Four10Click()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ten.Dequeue().SetActive(true);
        }
    }

}