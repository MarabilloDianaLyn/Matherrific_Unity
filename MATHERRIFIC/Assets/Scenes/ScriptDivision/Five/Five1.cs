using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Five1 : MonoBehaviour
{

    public GameObject[] objs;

    private Queue<GameObject> one;

    public void Start22()
    {
        one = new Queue<GameObject>();

        foreach (GameObject obj in objs)
        {
            obj.SetActive(false);
            one.Enqueue(obj);

        }
    }
    public void Five1Click()
    {
        if (Input.GetMouseButtonDown(0))
        {
            one.Dequeue().SetActive(true);
        }
    }

}