using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DOneSub : MonoBehaviour
{

    public GameObject disObject;

    public void DisappearObject4()
    {
        disObject.SetActive(false);
    }
}
