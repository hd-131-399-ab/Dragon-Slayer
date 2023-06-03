using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public GameObject SwordSwing;

    public Vector3 MousePos;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject swing = Instantiate(SwordSwing);

            MousePos = Input.mousePosition;

            Swing(swing);
        }
    }

    void Swing(GameObject swing)
    {
        MousePos = Camera.main.ScreenToWorldPoint(MousePos);

        Vector2 direction = new(MousePos.x - swing.transform.position.x, MousePos.y - swing.transform.position.y);

        swing.transform.up = direction;
    }
}