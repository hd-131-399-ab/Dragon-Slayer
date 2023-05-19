using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{
    public int _Range;

    public int _Damage;
    public float _Velocity;
    public float _Interval;

    private float mousePosX;
    private float mousePosY;

    Color color = Color.clear;

    private Inventory _Inventory;

    private void Start()
    {
        LineRenderer l = gameObject.AddComponent<LineRenderer>();
        _Inventory = gameObject.GetComponent<Inventory>();
    }

    void Update()
    {
        
    }

    private void BowRaycast()
    {

    }


}
