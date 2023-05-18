using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    public int WaveCount;

    private int CalculateSpawnAmount()
    {
        int spawnAmount = 0;

        int rndMultiplier = Random.Range(2, 5);

        spawnAmount = WaveCount * rndMultiplier;

        int rndAddition = Random.Range(10,35);

        spawnAmount += rndAddition;

        return spawnAmount;
    }
}
