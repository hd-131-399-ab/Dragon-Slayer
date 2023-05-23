using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrganDonorBehaviour : ItemBehaviour
{
    public OrganDonorBehaviour()
    {
        ID = 0;
    }

    public override void LoadItemBehaviour()
    {
        Player.AddComponent<Boomerang>();
    }
}
