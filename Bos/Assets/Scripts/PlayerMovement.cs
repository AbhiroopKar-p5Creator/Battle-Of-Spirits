using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController playerBody;
    public float jumpHeight = 3f;
    public float speed = 6f;

    public float damping = -2f;
    public float gravity = -9.81f;

    public GameObject ground;

     public float x;
     public float z;

    Vector3 velocity;
    bool isGrounded;

    
    void Update()
    {
     if(isGrounded && velocity.y < 0){
       velocity.y = -2f;  
     }
         
     x = Input.GetAxis("Horizontal");
     z = Input.GetAxis("Vertical");

     if(Input.GetKeyDown(KeyCode.Space) && isGrounded){
      velocity.y = Mathf.Sqrt(jumpHeight * damping * gravity);
     } 

     Vector3 playerMovement = (transform.right * x) + (transform.forward * z);
     velocity.y += gravity * Time.deltaTime;

     playerBody.Move(playerMovement * speed * Time.deltaTime);
     playerBody.Move(velocity * Time.deltaTime);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit) {
      if(hit.collider.gameObject == ground) {
       isGrounded = true;
      }else {
        isGrounded = false; 
      }
    }
}
