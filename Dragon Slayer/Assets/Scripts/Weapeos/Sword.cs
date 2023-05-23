using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public GameObject SwordSwing;

    public Vector2 MousePos;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            MousePos = Input.mousePosition;

            Swing();
        }
    }

    void Swing()
    {
        float angle = Vector2.Angle(gameObject.transform.position, MousePos);

        Instantiate(SwordSwing, gameObject.transform.position, Quaternion.identity);
    }
}