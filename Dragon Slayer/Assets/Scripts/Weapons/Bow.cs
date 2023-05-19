using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{
    public int _RangeX;
    public int _RangeY;

    public int _Damage;
    public float _Velocity;
    public float _Interval;

    private float mousePosX;
    private float mousePosY;

    Color color = Color.clear;

    private InventoryScript _Inventory;
    public Item EquipedItem;

    private void Start()
    {
        LineRenderer l = gameObject.AddComponent<LineRenderer>();
        _Inventory = gameObject.GetComponent<InventoryScript>();
        EquipedItem = gameObject.GetComponent<Item>();
    }

    void Update()
    {

    }

    private void BowRaycast()
    {

    }


}
