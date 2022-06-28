using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddThousands : MonoBehaviour
{

    public GameObject[] objssss;

    private Queue<GameObject> thousands;

    public void Start4()
    {
        thousands = new Queue<GameObject>();

        foreach (GameObject obj in objssss)
        {
            obj.SetActive(false);
            thousands.Enqueue(obj);

        }
    }
    public void ThousandClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            thousands.Dequeue().SetActive(true);
        }
    }

}