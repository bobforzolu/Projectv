using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState 
{
   protected Player player;
   protected PlayerStateMachine playerStateMachine;
   protected Character_Data character_Data;
   protected float startTime;
   protected bool isAnimationFinished;
   private string animBoolName;
   protected bool IsExitingState;
  


   public PlayerState(Player player, PlayerStateMachine playerStateMachine, Character_Data character_Data, string animBoolName)
   {
       this.player = player;
       this.playerStateMachine = playerStateMachine;
       this.character_Data = character_Data;
       this.animBoolName = animBoolName;
   }
   public virtual void Enter(){
       DoChecks();
       player.Anim.SetBool(animBoolName, true);
       startTime = Time.time;
      // Debug.Log(animBoolName);
       isAnimationFinished = false;
       IsExitingState = false;
   }
   public virtual void LogicUpdate(){
   }
   public virtual void PhysicsUpdate(){
        DoChecks();
   }
   public virtual void Exit(){
        player.Anim.SetBool(animBoolName, false);
        IsExitingState = true;
   }
  
  // looks for ground check and air cheeck
   public virtual void DoChecks(){

   }
    public virtual void AnimationTrigger() {

    }
    
    public virtual void AnimationFinishTrigger() => isAnimationFinished = true;

}
