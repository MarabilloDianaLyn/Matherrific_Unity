using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Five100 : MonoBehaviour
{

    public GameObject[] objs;

    private Queue<GameObject> hundred;

    public void Start24()
    {
        hundred = new Queue<GameObject>();

        foreach (GameObject obj in objs)
        {
            obj.SetActive(false);
            hundred.Enqueue(obj);

        }
    }
    public void Five100Click()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hundred.Dequeue().SetActive(true);
        }
    }

}