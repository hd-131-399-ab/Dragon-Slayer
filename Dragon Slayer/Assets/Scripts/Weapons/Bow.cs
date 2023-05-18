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

    private void Start()
    {
        LineRenderer l = gameObject.AddComponent<LineRenderer>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            //int rayLenghtX = Screen.width / 2;

            //RaycastHit2D hit = Physics2D.Raycast(transform.position,Vector2.up, rayLenghtX);

            mousePosX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
            mousePosY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;

            LineRenderer l = GetComponent<LineRenderer>();

            List<Vector3> pos = new List<Vector3>();
            pos.Add(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y));
            pos.Add(new Vector3(mousePosX,mousePosY));
            l.material = new Material(Shader.Find("Sprites/Default"));
            l.material.color = Color.red;
            l.startWidth = 0.1f;
            l.endWidth = 0.1f;
            l.SetPositions(pos.ToArray());
            l.useWorldSpace = true;
        }
    }

}
