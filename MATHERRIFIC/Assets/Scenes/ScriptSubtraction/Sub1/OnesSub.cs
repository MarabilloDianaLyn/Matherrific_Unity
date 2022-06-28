using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnesSub : MonoBehaviour
{

    public GameObject disObject;

    public void DisappearObject()
    {
        disObject.SetActive(false);
    }
}
