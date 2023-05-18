using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    public int WaveCount;
    public int SpawnAmount;
    public int ZombieAmount;

    public void NextWave()
    {
        WaveCount++;

        CalculateSpawnAmount();
    }

    private void CalculateSpawnAmount()
    {
        SpawnAmount = 0;
        int rndMultiplier = Random.Range(2, 4);
        
        if (WaveCount <= 40)
        {
            SpawnAmount = WaveCount * rndMultiplier;
        }
        else
        {
            SpawnAmount = WaveCount * 2;
            SpawnAmount += 50;
        }

        int rndAddition;
        if (WaveCount < 10)
        {
            rndAddition = Random.Range(3, 9);

            SpawnAmount += rndAddition;
        }
        else
        {
            rndAddition = Random.Range(10, 25);

            SpawnAmount += rndAddition;
        }
    }

    private void CalculateSpawnDistribution()
    {
        ZombieAmount = SpawnAmount;
    }

    private void SpawnEnemys()
    {

    }
}
