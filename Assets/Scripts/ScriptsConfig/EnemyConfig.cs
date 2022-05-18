using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "EnemyConfig", menuName = "Configs/Enemy/Create Enemy Config")]
public class EnemyConfig : ScriptableObject
{
    [SerializeField] public int minHealth = 100;
    [SerializeField] public int maxHealth = 500;
}