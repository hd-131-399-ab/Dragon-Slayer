using System.Collections;
using UnityEngine;

public class Bow : MonoBehaviour
{
    public int _Range;

    public int _Damage;
    public float _Velocity;
    public float _Interval;

    private bool allowFire = true;

    private IEnumerator example;

    private Inventory _Inventory;
    private EnemyHealthScript _EnemyHealth;

    private GameObject _HitEnemy;

    private void Start()
    {
        _Inventory = gameObject.GetComponent<Inventory>();

        example = Example();
    }

    IEnumerator Example()
    {
        allowFire = false;

        print(Time.time);

        yield return new WaitForSeconds(_Interval);

        print(Time.time);
    }

    void Update()
    {     
        if (Input.GetMouseButtonDown(0) && allowFire)
        {

            StartCoroutine(Example());
        }
    }

    void FireWeapon()
    {
        if (_Inventory.EquipedItem == 1)
        {
            print("Shoot");
        }
    }
}