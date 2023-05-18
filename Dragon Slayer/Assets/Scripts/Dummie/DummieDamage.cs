using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummieDamage : MonoBehaviour
{
    public int Health;
    public int Damage;

    public string gameObjectName;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == gameObjectName)
        {
            Health -= Damage;
        }
    }
}
