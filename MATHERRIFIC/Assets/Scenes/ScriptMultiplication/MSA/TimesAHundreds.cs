using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimesAHundreds : MonoBehaviour
{

    public GameObject[] objs;

    private Queue<GameObject> ahundreds;

    public void StartC()
    {
        ahundreds = new Queue<GameObject>();

        foreach (GameObject obj in objs)
        {
            obj.SetActive(false);
            ahundreds.Enqueue(obj);

        }
    }
    public void CClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ahundreds.Dequeue().SetActive(true);
        }
    }

}