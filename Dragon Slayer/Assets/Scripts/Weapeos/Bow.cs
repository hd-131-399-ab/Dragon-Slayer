using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{
    public int _Range;

    public int _Damage;
    public float _Velocity;
    public float _Interval;

    private Inventory PlayerInventory;
    private EnemyHealthScript _EnemyHealth;

    private void Start()
    {
        LineRenderer l = gameObject.AddComponent<LineRenderer>();
        PlayerInventory = gameObject.GetComponent<Inventory>();
        _EnemyHealth = gameObject.GetComponent<EnemyHealthScript>();

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //if smth mit Inventar

            BowRaycast();
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
