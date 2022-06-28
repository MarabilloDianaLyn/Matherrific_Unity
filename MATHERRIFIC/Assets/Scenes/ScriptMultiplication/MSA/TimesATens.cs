using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimesATens : MonoBehaviour
{

    public GameObject[] objs;

    private Queue<GameObject> atens;

    public void StartB()
    {
        atens = new Queue<GameObject>();

        foreach (GameObject obj in objs)
        {
            obj.SetActive(false);
            atens.Enqueue(obj);

        }
    }
    public void BClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            atens.Dequeue().SetActive(true);
        }
    }

}