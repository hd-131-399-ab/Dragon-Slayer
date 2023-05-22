using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowBehaviour : ItemBehaviour
{
    public List<string> ScriptNames;

	public BowBehaviour()
	{
		ID = 1;
        ScriptNames = new();
    }

    public override void LoadItemBehaviour()
    {
        Player.AddComponent<Bow>();
        Player.AddComponent<AimingSystem>();

        ScriptNames.Add(nameof(Bow));
        ScriptNames.Add(nameof(AimingSystem));
    }
}
