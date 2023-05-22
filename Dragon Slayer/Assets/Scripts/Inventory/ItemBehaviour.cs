using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehaviour : MonoBehaviour
{
    public int ID;
    protected GameObject Player;

    private void Start()
    {
        Player = GameObject.FindWithTag("Player");
    }

    public virtual void LoadItemBehaviour()
    {

    }
}
