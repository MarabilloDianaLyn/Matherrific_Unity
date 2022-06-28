using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Two10 : MonoBehaviour
{

    public GameObject[] objs;

    private Queue<GameObject> ten;

    public void Start15()
    {
        ten = new Queue<GameObject>();

        foreach (GameObject obj in objs)
        {
            obj.SetActive(false);
            ten.Enqueue(obj);

        }
    }
    public void Two10Click()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ten.Dequeue().SetActive(true);
        }
    }

}