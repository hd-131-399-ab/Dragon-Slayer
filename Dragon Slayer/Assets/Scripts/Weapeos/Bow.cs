using System.Collections;
using UnityEngine;

public class Bow : MonoBehaviour
{
    public int _Range;

    public int _Damage;
    public float _Velocity;
    public float _Interval;

    private bool allowFire = true;

    private Inventory _Inventory;
    private EnemyHealthScript _EnemyHealth;

    private GameObject _HitEnemy;

    private void Start()
    {
        _Inventory = gameObject.GetComponent<Inventory>();

        _Interval = 2;
    }
    void Update()
    {     
        if (Input.GetMouseButtonDown(0) && allowFire)
        {

            StartCoroutine(Example());
        }
    }

    IEnumerator Example()
    {
        FireWeapon();
        
        yield return new WaitForSeconds(_Interval);

        allowFire = true;
    }

    void FireWeapon()
    {
        if (_Inventory.EquipedItem == 1)
        {
            print("Shoot");

            allowFire = false;
        }
    }
}