using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Random = UnityEngine.Random;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] private EnemyConfig enemyConfig;
    [SerializeField] private TextMeshPro text;
    [SerializeField] private BulletConfig bulletConfig;
    private int _enemyHealth;


    // Start is called before the first frame update
    void Start()
    {
        _enemyHealth = GetEnemyHealth();
        text.text = _enemyHealth.ToString();
    }

    private int GetEnemyHealth()
    {
        var enemyHealth = Random.Range(0, enemyConfig.maxHealth);
        return enemyHealth;
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Bullet":
                _enemyHealth -= bulletConfig.bulletDamage;
                UpdateHealthText();
                IsAlive();
                break;
            case "Player":
                print("GameOver");
                break;
        }
    }

    private void UpdateHealthText()
    {
        text.text = _enemyHealth.ToString();
    }

    private void IsAlive()
    {
        if (_enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}