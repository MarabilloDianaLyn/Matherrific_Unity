using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class One1 : MonoBehaviour
{

    public GameObject[] objs;

    private Queue<GameObject> one;

    public void Start11()
    {
        one = new Queue<GameObject>();

        foreach (GameObject obj in objs)
        {
            obj.SetActive(false);
            one.Enqueue(obj);

        }
    }
    public void One1Click()
    {
        if (Input.GetMouseButtonDown(0))
        {
            one.Dequeue().SetActive(true);
        }
    }

}