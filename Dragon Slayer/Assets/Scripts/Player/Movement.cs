using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject player;

    public float speed;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        player.transform.Translate(new Vector2(horizontalInput, verticalInput) * speed * Time.deltaTime);
    }
}