using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class SliderText : MonoBehaviour
{
    Text percentageText;

    void Start()
    {
        percentageText = GetComponent<Text> ();
    }

    public void textUpdate(float value)
    {
        percentageText.text = Mathf.RoundToInt(value * 100) + "%";
    }
}