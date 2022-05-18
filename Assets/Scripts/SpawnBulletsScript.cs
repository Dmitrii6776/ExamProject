using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathologicalGames;

public class SpawnBulletsScript : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private BulletConfig bulletConfig;
    private int _count;

    // Update is called once per frame
    void Update()
    {
        CheckSpawnBullets();
    }

    void SpawnBullet()
    {
        PoolManager.Pools["BulletSpawn"].Spawn(bulletPrefab.transform);
    }

    void CheckSpawnBullets()
    {
        var spawnBulletSpeed = bulletConfig.bulletSpawnSpeed;
        if (_count == spawnBulletSpeed)
        {
            SpawnBullet();
            _count = 0;
        }
        else
        {
            _count++;
        }
    }
}