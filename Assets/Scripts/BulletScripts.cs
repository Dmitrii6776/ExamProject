using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathologicalGames;


public class BulletScripts : MonoBehaviour
{
    [SerializeField] private BulletConfig bulletConfig;


    // Update is called once per frame
    void Update()
    {
        BulletMove();
    }

    void BulletMove()
    {
        var bulletSpeed = bulletConfig.bulletSpeed * Time.deltaTime;
        transform.position += new Vector3(0, 0, bulletSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}