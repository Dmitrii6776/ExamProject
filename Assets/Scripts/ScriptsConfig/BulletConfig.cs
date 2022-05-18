using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BulletConfig", menuName = "Configs/Bullet/Create Bullet Config")]
public class BulletConfig : ScriptableObject
{
    [SerializeField] public int bulletSpeed = 20;
    [SerializeField] public float bulletSpawnSpeed = 0.2f;
    [SerializeField] public int bulletDamage = 30;

}