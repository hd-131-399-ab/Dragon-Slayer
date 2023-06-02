using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public GameObject SwordSwing;

    public Vector2 MousePos;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MousePos = Input.mousePosition;

            Swing();
        }
    }

    void Swing()
    {
        
    }
}