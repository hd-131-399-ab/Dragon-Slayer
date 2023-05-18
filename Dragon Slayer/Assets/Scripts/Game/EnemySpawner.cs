using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner
{
    public GameObject Enemy;
    public GameObject Player;

    private List<Vector2> SpawnCords;
    public List<GameObject> Enemys;

    public EnemySpawner(GameObject enemy, GameObject player)
    {
        Enemy = enemy;
        Player = player;

        Enemy.GetComponent<AIDestinationSetter>().target = Player.transform;

        SpawnCords = new();
        Enemys = new();
    }

    private Vector2 GenerateRndCords()
    {
        int rndDirection = Random.Range(0, 3);

        float rndX = 0;
        float rndY = 0;

        switch (rndDirection)
        {
            case 0:
                rndY = Random.Range(16, 23);
                rndX = Random.Range(-16, 23);
                break;
            case 1:
                rndY = Random.Range(-11, 23);
                rndX = Random.Range(16, 23);
                break;
            case 2:
                rndY = Random.Range(-11, -1);
                rndX = Random.Range(-16, 23);
                break;
            case 3:
                rndY = Random.Range(-11, 23);
                rndX = Random.Range(-23, -16);
                break;
        }

        return new Vector2(rndX, rndY);
    }

    public void SpawnEnemy()
    {
        Vector2 rndCords = GenerateRndCords();

        if (!SpawnCords.Contains(rndCords))
        {
            GameObject enemy = (GameObject)MonoBehaviour.Instantiate(Enemy, rndCords, Quaternion.identity);

            Enemys.Add(enemy);
        }
        else
        {
            SpawnEnemy();
        }
    }
}
