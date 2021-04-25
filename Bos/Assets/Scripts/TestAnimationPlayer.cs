using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAnimationPlayer : MonoBehaviour
{   
  public Animations[] animations;
  public Animations resetAnimation;
  Animator animator;

  float countDown;
  string currentState;

   void Start()
   {
    animator = GetComponent<Animator>();
   }

   void Update(){
       if(Input.GetKeyDown(KeyCode.B)){
         PlayAnimation("Hands-One");
       }
   }
 void PlayAnimation(string animationName){    
    foreach (Animations chosenAnimation in animations){
     
     // playing the animation   
      if(chosenAnimation.name == animationName){
       animator.Play(chosenAnimation.name);
      }else if(animationName != chosenAnimation.name){
        Debug.LogWarning("Animation With The Name " + animationName + " Not Found (101)");  
      }   
    }
   }
}
