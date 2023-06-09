using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimingSystem : MonoBehaviour
{
    [HideInInspector]
    public static float mousePosX;
    public static float mousePosY;

    private float _CalculatedDiffrenceX;
    private float _CalculatedDiffrenceY;

    private Vector3 _GameObjectPosition;

    Color _Color = Color.clear;

    private Bow Bow;

    private void Start()
    {
        gameObject.AddComponent<LineRenderer>();
        Bow = gameObject.GetComponent<Bow>();
    }

    void Update()
    {
        CheckForGameObject(); 

        // Wenn der Bogen ausgew�hlt ist dann l�uft das aiming system durchgehend durch
        // Bei der X achse nur die Halfte von der y Achse nehemen
        mousePosX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
        mousePosY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;

        _CalculatedDiffrenceX = (_GameObjectPosition.x - mousePosX);
        _CalculatedDiffrenceY = (_GameObjectPosition.y - mousePosY);

        if (_CalculatedDiffrenceX > Bow._Range || _CalculatedDiffrenceY > Bow._Range)
        {
            _Color = Color.red;
        }
        else
        {
            _Color = Color.green;
        }

        List<Vector3> pos = new List<Vector3>();
        pos.Add(new Vector3(gameObject.transform.position.x, gameObject.transform.position.y));

        LineRenderer l = GetComponent<LineRenderer>();

        pos.Add(new Vector3(mousePosX, mousePosY));
        l.material = new Material(Shader.Find("Sprites/Default"));
        l.material.color = _Color;
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
