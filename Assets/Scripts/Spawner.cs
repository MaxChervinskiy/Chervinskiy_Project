using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Spawner : MonoBehaviour
{

    public GameObject[] enemy = new GameObject[4];
    private List<GameObject> enemys;
    Transform randomSpawnPoint
    {
        get
        {
            int randIndex = UnityEngine.Random.Range(0, transform.childCount);
            return transform.GetChild(randIndex);
        }
    }

    public float spawnDelay = 3;

   public int currentEnemycount;
   public int currentWaveNumber = 1;
    public int Score = 0;
    void EnemyHasDie() {
        currentEnemycount--;
    }

    void Start()
    {
        CountEnemy();
        Spawn();

    }

    private void CountEnemy()
    {
        currentEnemycount = currentWaveNumber * 5;
    }

    private void Spawn()
    {
        enemys = new List<GameObject>();

        for (int i = 0; i < currentEnemycount; i++)
        {
           AddEnemys();
        }
    }

    private void AddEnemys()
    {
        enemys.Add((GameObject)Instantiate(enemy[UnityEngine.Random.Range(0, enemy.Length)], randomSpawnPoint.position, Quaternion.identity));
    }

    void Update()
    {
        CheckIfReadySpawn();

        GameObject current = null;
        bool flag = false;
        foreach (var en in enemys)
        {
            if (en != null && en.GetComponentInChildren<Enemy>() == null)
            {
                current = en;
                Destroy(en);
                flag = true;
                EnemyHasDie();
                Score += 10;
            }
        }
        if (flag)
        {
            flag = false;
            enemys.Remove(current);
        }
    }

    private void CheckIfReadySpawn()
    {
        if (currentEnemycount <= 0)
        {
            currentWaveNumber++;
            CountEnemy();
            Invoke("Spawn", spawnDelay);
        }
    }
}
