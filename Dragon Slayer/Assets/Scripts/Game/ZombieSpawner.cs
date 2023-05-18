using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject Zombie;

    void Start()
    {
        //Zombie.GetComponent<AIDestinationSetter>().target = gameObject.transform;

        Instantiate(Zombie, new Vector2(0, -1), Quaternion.identity);
    }
}
