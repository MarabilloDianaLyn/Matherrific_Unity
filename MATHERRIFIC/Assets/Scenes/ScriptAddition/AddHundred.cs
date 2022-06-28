using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddHundred : MonoBehaviour
{

    public GameObject[] objsss;

    private Queue<GameObject> hundred;

    public void Start3()
    {
        hundred = new Queue<GameObject>();

        foreach (GameObject obj in objsss)
        {
            obj.SetActive(false);
            hundred.Enqueue(obj);

        }
    }
    public void HundredClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            hundred.Dequeue().SetActive(true);
        }
    }

}
