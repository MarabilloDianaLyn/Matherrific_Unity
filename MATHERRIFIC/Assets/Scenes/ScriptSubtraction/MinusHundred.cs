using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinusHundred : MonoBehaviour
{

    public GameObject[] objs;

    private Queue<GameObject> hundred;

    public void Start7()
    {
        hundred = new Queue<GameObject>();

        foreach (GameObject obj in objs)
        {
            obj.SetActive(false);
            hundred.Enqueue(obj);

        }
    }
    public void MinusHundredClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hundred.Dequeue().SetActive(true);
        }
    }

}
