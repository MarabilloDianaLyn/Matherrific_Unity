using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinusThousand : MonoBehaviour
{

    public GameObject[] objs;

    private Queue<GameObject> thousand;

    public void Start8()
    {
        thousand = new Queue<GameObject>();

        foreach (GameObject obj in objs)
        {
            obj.SetActive(false);
            thousand.Enqueue(obj);

        }
    }
    public void MinusThousandClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            thousand.Dequeue().SetActive(true);
        }
    }

}
