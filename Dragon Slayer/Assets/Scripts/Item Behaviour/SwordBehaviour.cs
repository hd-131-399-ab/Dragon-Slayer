using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordBehaviour : ItemBehaviour
{
	public SwordBehaviour()
	{
		ID = 2;
	}

    public override void LoadItemBehaviour()
    {
        Player.AddComponent<Sword>();
        //Player.AddComponent<AimingSystem>();
    }
}
