using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
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

    private GameObject _HitEnemy;

    private void Start()
    {
        LineRenderer l = gameObject.AddComponent<LineRenderer>();
        _Inventory = gameObject.GetComponent<Inventory>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (true)
            {
                // Bug Irgenwas was nicht auskommentiert ist fehlt die object refernce

                Vector2 ray = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);

                RaycastHit2D hit = Physics2D.Raycast(ray, ray);

                _HitEnemy = GameObject.Find("Zombie");

                if (hit.collider.gameObject.tag == "Enemy" || hit.collider.gameObject.name == "Zombie")
                {
                    _EnemyHealth = _HitEnemy.GetComponent<EnemyHealth>();

                    _EnemyHealth._Instance = hit.collider.gameObject;
                }
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
            _EnemyHealth._Instance = hit.collider.gameObject;
        }
    }
}
