using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics : MonoBehaviour
{  
    #region Declarations
    [Tooltip("Sets Weather Accaelaration Increases or not")]
    public bool constantAcclaration;
    
    [Space]

    public Vector3 velocity;
    public Vector3 position;
    public Vector3 acclaration;

    [Space]

    [Range(0f,100f)]
    public float gravity = 9.81f;

    [Range(0f,10f)]
    public float mass = 1f;

    [HideInInspector]   
    public bool boostAccelaration;
    [HideInInspector]
    public float boostAcc;       
     
    #endregion

    void Start()
    {
      
      #region DeclarationQualification
       velocity = new Vector3(0f,0f,0f);
       position = new Vector3(0f,0f,0f);

      #endregion  
    }

		
    void FixedUpdate()
    {
     #region Speed
      if(boostAccelaration == true){
        acclaration.x += boostAcc;
        acclaration.y += boostAcc;
        acclaration.z += boostAcc;
      }
     #endregion   
    }

  #region MyMethods
    public void SetSpeed(float x ,float y ,float z ,float increase){
     if(constantAcclaration == true){   
      boostAccelaration = false;
      velocity = new Vector3(x,y,z);
     }else{
       boostAcc = increase;
       boostAccelaration = true;
      
     }
    }

    public void UpdatePhysics(){

     position.x += velocity.x;
     position.y += velocity.y;
     position.z += velocity.z;

     velocity.x += acclaration.x;
     velocity.y += acclaration.y;
     velocity.z += acclaration.z;
    }

    public void applyForce(Vector3 force){
    float ActualforceX = force.x / mass;
    float ActualforceY = force.y / mass;
    float ActualforceZ = force.z / mass;


     acclaration.x += ActualforceX;
     acclaration.y += ActualforceY;
     acclaration.z += ActualforceZ;

    }
  #endregion


}
