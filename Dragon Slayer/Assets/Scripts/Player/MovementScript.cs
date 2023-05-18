using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    public GameObject Player;

    public float Speed;

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Player.transform.Translate(new Vector2(horizontalInput, verticalInput) * Speed * Time.deltaTime);
    }
}