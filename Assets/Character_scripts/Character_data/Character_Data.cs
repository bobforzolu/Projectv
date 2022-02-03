using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newPlayerData", menuName = "Data/Player Data/Base Data" )]
public class Character_Data : ScriptableObject
{
   [Header("Move State")]
   public float movementVelocity = 10f;
}
