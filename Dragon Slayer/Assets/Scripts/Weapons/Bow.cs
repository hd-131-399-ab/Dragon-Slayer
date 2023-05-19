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
    private EnemyHealth _EnemyHealth;

    private void Start()
    {
        LineRenderer l = gameObject.AddComponent<LineRenderer>();
        _Inventory = gameObject.GetComponent<Inventory>();
        _EnemyHealth = gameObject.GetComponent<EnemyHealth>();

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (true)
            {
                BowRaycast();
            }
        }
    }

    private void BowRaycast()
    {
        Vector2 ray = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);

        RaycastHit2D hit = Physics2D.Raycast(ray, ray);

        if (hit.collider.gameObject.tag == "Enemy")
        {
            _EnemyHealth.Health -= _Damage;
        }
    }
}
