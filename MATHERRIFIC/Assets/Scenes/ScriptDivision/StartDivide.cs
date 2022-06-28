using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartDivide : MonoBehaviour
{

    public GameObject TextBox;
    public GameObject TextBox1;
    public GameObject CorrectBox;
    public int Answer1;
    public int num1;
    public int num2;


    public void RandomGenerate()
    {
        num1 = Random.Range(1, 100);
        num2 = Random.Range(2, 10);
        TextBox.GetComponent<Text>().text = "" + num1;
        TextBox1.GetComponent<Text>().text = "" + num2;
    }
}
