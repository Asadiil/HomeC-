using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Minus : MonoBehaviour
{
    public InputField FirstNum;
    public InputField SecondNum;
    public Text OtvetNum;

    public void onMinus()
    {
       OtvetNum.text = (Convert.ToDouble(FirstNum.text) - Convert.ToDouble(SecondNum.text)).ToString();
    }
}
