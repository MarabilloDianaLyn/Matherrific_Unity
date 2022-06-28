using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DivideSkittle : MonoBehaviour
{

    public GameObject[] objs;

    private Queue<GameObject> skittle;

    public void Start50()
    {
        skittle = new Queue<GameObject>();

        foreach (GameObject obj in objs)
        {
            obj.SetActive(false);
            skittle.Enqueue(obj);

        }
    }
    public void VideSkittleClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            skittle.Dequeue().SetActive(true);
        }
    }

}
