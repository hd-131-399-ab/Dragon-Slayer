using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimingSystem : MonoBehaviour
{
    private float mousePosX;
    private float mousePosY;

    Color color = Color.clear;

    private Bow _Bow;

    private void Start()
    {
        LineRenderer l = gameObject.AddComponent<LineRenderer>();
        _Bow = gameObject.GetComponent<Bow>();
    }

    void Update()
    {
        // Wenn der Bogen ausgewählt ist dann läuft das aiming system durchgehend durch \\

        mousePosX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
        mousePosY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;

        if (mousePosX > _Bow._Range || mousePosY > _Bow._Range)
        {
            color = Color.red;
        }
        else
        {
            color = Color.green;
        }

        List<Vector3> pos = new List<Vector3>();
        pos.Add(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y));

        LineRenderer l = GetComponent<LineRenderer>();

        pos.Add(new Vector3(mousePosX, mousePosY));
        l.material = new Material(Shader.Find("Sprites/Default"));
        l.material.color = color;
        l.startWidth = 0.1f;
        l.endWidth = 0.1f;
        l.SetPositions(pos.ToArray());
        l.useWorldSpace = true;
    }
}
