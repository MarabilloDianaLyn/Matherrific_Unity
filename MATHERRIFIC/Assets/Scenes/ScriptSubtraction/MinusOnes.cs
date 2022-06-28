using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinusOnes : MonoBehaviour
{

    public GameObject[] objssss;

    private Queue<GameObject> ones;

    public void Start5()
    {
        ones = new Queue<GameObject>();

        foreach (GameObject obj in objssss)
        {
            obj.SetActive(false);
            ones.Enqueue(obj);

        }
    }
    public void MinusOnesClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ones.Dequeue().SetActive(true);
        }
    }

}
