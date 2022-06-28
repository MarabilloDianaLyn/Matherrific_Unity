using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BOneSub : MonoBehaviour
{

    public GameObject disObject;

    public void DisappearObject2()
    {
        disObject.SetActive(false);
    }
}
