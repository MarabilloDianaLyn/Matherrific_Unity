using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EOneSub : MonoBehaviour
{

    public GameObject disObject;

    public void DisappearObject5()
    {
        disObject.SetActive(false);
    }
}
