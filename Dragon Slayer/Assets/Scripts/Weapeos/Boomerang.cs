using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Boomerang : MonoBehaviour
{
    public float _Range;
    public float _Speed;
    public float _Delay;

    private Vector2 _TargetPos;

    private Vector3 _PlayerPos;


    private bool _AllowFire = true;

    public GameObject _Boomerang;

    private Inventory _Inventory;

    private void Start()
    {
        _Inventory = gameObject.GetComponent<Inventory>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && _Inventory.EquipedItem.ToShortString() == "Organspende" && _AllowFire)
        {
            StartCoroutine(Delay());
        }
    }

    IEnumerator Delay()
    {
        FireBoomerang();

        yield return new WaitForSecondsRealtime(_Delay);

        _AllowFire = true;
    }

    void GetTargetPositon()
    {
        _TargetPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
    }

    void GetPlayerPosition()
    {
         _PlayerPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0);
    }

    void FireBoomerang()
    {
        GetTargetPositon();

        GetPlayerPosition();

        Instantiate(Resources.Load("OrganspendeRang"),_PlayerPos,Quaternion.identity);

        _AllowFire = false;
    }
}
