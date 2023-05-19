using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimingSystem : MonoBehaviour
{
    private float mousePosX;
    private float mousePosY;

    private float _CalculatedDiffrenceX;
    private float _CalculatedDiffrenceY;

    private Vector3 _GameObjectPosition;

    Color color = Color.clear;

    private Bow _Bow;

    private void Start()
    {
        LineRenderer l = gameObject.AddComponent<LineRenderer>();
        _Bow = gameObject.GetComponent<Bow>();
    }

    void Update()
    {
       CheckForGameObject();   

        // Wenn der Bogen ausgewählt ist dann läuft das aiming system durchgehend durch \\
        // Bei der X achse nur die Halfte von der y Achse nehemen
        mousePosX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
        mousePosY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;

        _CalculatedDiffrenceX = (_GameObjectPosition.x - mousePosX);
        _CalculatedDiffrenceY = (_GameObjectPosition.y - mousePosY);

        if (_CalculatedDiffrenceX > _Bow._Range || _CalculatedDiffrenceY > _Bow._Range)
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

    private void CheckForGameObject()
    {
        Vector2 ray = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);

        RaycastHit2D hit = Physics2D.Raycast(ray, ray);

        if (hit.collider != null)
        {
            Debug.Log(hit.collider.gameObject.transform.position);
            _GameObjectPosition = hit.collider.gameObject.transform.position;
        }
    }
}
