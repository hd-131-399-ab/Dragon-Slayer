using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSDisplay : MonoBehaviour
{
    public Text FPSFrame;

    private bool _SecondOver = true;

    void Update()
    {
        if (_SecondOver)
        {
            StartCoroutine(Second());
        }
    }

    IEnumerator Second()
    {
        _SecondOver = false;

        yield return new WaitForSecondsRealtime(1);

        float fPS = 1.0f / Time.deltaTime;
        int intFPS = (int)fPS;

        FPSFrame.text = intFPS.ToString();
        _SecondOver = true;
    }
}
