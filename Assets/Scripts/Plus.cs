using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Plus : MonoBehaviour
{
    public InputField FirstNum;
    public InputField SecondNum;
    public Text OtvetNum;

    public void onPlus()
    {
        OtvetNum.text = (Convert.ToInt32(FirstNum.text) + Convert.ToInt32(SecondNum.text)).ToString();
    }
}