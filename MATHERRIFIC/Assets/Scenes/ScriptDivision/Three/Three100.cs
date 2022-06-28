using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Three100 : MonoBehaviour
{

    public GameObject[] objs;

    private Queue<GameObject> hundred;

    public void Start19()
    {
        hundred = new Queue<GameObject>();

        foreach (GameObject obj in objs)
        {
            obj.SetActive(false);
            hundred.Enqueue(obj);

        }
    }
    public void Three100Click()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hundred.Dequeue().SetActive(true);
        }
    }

}