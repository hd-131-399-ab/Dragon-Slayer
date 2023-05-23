using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowBehaviour : ItemBehaviour
{
	public BowBehaviour()
	{
		ID = 1;
    }

    public override void LoadItemBehaviour()
    {
        Player.AddComponent<Bow>();
        Player.AddComponent<AimingSystem>();
    }
}
