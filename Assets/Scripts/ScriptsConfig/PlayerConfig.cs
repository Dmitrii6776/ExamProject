using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "playerConfig", menuName = "Configs/Player/Create Player Config")]
public class PlayerConfig : ScriptableObject
{
    [SerializeField] public int speed = 5;
    
    [SerializeField] public int leftRightSpeed = 10;
    
}