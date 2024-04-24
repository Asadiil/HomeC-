using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Del : MonoBehaviour
{
    public InputField FirstNum;
    public InputField SecondNum;
    public Text OtvetNum;

    public void onDel()
    {
        OtvetNum.text = (Convert.ToDouble(FirstNum.text) / Convert.ToDouble(SecondNum.text)).ToString();
    }
}