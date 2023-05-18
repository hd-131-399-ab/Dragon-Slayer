using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class DamageScript : MonoBehaviour
{
    public float Health;
    public float Maxhealth;
    public int Damage;

    public Image HealthBar;
    public GameObject Player;

    private void Start()
    {
        Health = Maxhealth;
    }

    private void Update()
    {
        HealthBar.fillAmount = Health / Maxhealth;

        if (Health <= 0)
        {
            Destroy(Player);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Health -= Damage;

            print(Health);
        }
    }
}
