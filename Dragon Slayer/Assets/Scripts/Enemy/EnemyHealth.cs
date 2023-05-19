using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public float MaxHealth;

    private float _Health;
    public float Health
    {
        get => _Health;
        set
        {
            if (value <= 0)
            {
                Destroy(this);
            }
        }
    }

    public Image HealthBar;

    void Start()
    {
        _Health = MaxHealth;
    }
}
