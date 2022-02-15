using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newPlayerData", menuName = "Data/Player Data/Base Data" )]
public class Character_Data : ScriptableObject
{
   [Header("Move State")]
   public float playerMovementVelocity = 10f;

   [Header("jump Velocity")]
   public float playerJumpVelocity = 15f;

   [Header("aire state")]
   public float variableJumpMuliplier = 0.5f;

   [Header("check variables")]
   public float groundcheckRadius = 0.3f;
   public LayerMask whatIsGround;

   [Header("spike ")]

   public float spikePlayerVelocity = 15f;   
   public bool CanSpike  = true;

   [Header("sett variables")]
   public float settPlayerVelocity = 0f;
   public bool CanSetball = false;

  [Header("save state")]
  public float saveSpeed = 10f;
  public bool ExecutingSave;
  [Header("lob")]
  public float lobSpeed = 0f;

  [Header("block")]
  public float blockSpeed = 0f;

}
