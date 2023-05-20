using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bow : MonoBehaviour
{
    public int _Range;

    public int _Damage;
    public float _Velocity;
    public float _SetInterval;

    private float _Interval;
    private float mousePosX;
    private float mousePosY;

    Color color = Color.clear;

    RaycastHit2D hit;

    Vector2 rayCastDirection;

    private Inventory _Inventory;
    private EnemyHealth _EnemyHealth;

    private GameObject _HitEnemy;

    private void Start()
    {
        LineRenderer l = gameObject.AddComponent<LineRenderer>();
        _Inventory = gameObject.GetComponent<Inventory>();
        _Interval = _SetInterval;
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            if (_Inventory.EquipedItem == 1 || _Interval == 0)
            {
                print("Fire");

                _Interval = _SetInterval;
            }
        }
    }
}
