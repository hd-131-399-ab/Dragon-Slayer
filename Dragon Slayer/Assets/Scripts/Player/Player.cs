using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int MaxHealth;

    int _Health;
    public int Health
    {
        get => _Health;

        set
        {
            if (value <= 0)
            {
                print("dead");
                Destroy(gameObject.transform.parent);
            }

            _Health = value;
        }
    }

    private void Start()
    {
        Health = MaxHealth;
    }
}
