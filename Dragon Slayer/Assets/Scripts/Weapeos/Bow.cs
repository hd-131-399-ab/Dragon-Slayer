using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Bow : MonoBehaviour
{
    private float _Interval;

    public float _Range;

    private bool allowFire = true;

    private Inventory _Inventory;
    private EnemyHealthScript _EnemyHealth;

    private void Start()
    {
        _Inventory = gameObject.GetComponent<Inventory>();

        _Interval = 2;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && allowFire)
        {

            StartCoroutine(FireDelay());
        }
    }

    IEnumerator FireDelay()
    {
        FireWeapon();

        yield return new WaitForSecondsRealtime(_Interval);

        allowFire = true;
    }

    void FireWeapon()
    {
        if (_Inventory.EquipedItem.ToShortString(3) == "Bow")
        {
            print("Shoot");

            allowFire = false;
            //Instantiate();
        }

    }
}