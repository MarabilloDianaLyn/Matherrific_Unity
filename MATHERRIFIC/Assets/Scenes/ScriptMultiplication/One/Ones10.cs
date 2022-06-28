using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ones10 : MonoBehaviour
{

    public GameObject[] objs;

    private Queue<GameObject> ten;

    public void Start12()
    {
        ten = new Queue<GameObject>();

        foreach (GameObject obj in objs)
        {
            obj.SetActive(false);
            ten.Enqueue(obj);

        }
    }
    public void One10Click()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ten.Dequeue().SetActive(true);
        }
    }

}