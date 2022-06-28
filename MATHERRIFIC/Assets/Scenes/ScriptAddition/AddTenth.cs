using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddTenth : MonoBehaviour
{

    public GameObject[] objss;

    private Queue<GameObject> tenth;

    public void Start2()
    {
        tenth = new Queue<GameObject>();

        foreach (GameObject obj in objss)
        {
            obj.SetActive(false);
            tenth.Enqueue(obj);
        }
    }

    public void TenthClicked()
    {
        if (Input.GetMouseButtonDown(0))
        {
            tenth.Dequeue().SetActive(true);
        }
    }
}

