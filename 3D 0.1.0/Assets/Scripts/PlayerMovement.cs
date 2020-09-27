using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
  public CharacterController Controller;

  public float Speed = 12f;
  public float Gravity = -9.81f;
  public float jumpheight = 3f;

  public Transform GroundChack;
  public float GroundDistance = 0.4f;
  public LayerMask GroundMask;
  bool isgrounded;
  Vector3 velocity;

 
     ////////////////////////////////////////// 
    void Update()
    {
      movement();
      JumpAndGravity();
      
    }

    //////////////////////////////////////////
    void movement()
    {
    //input geting
      float x = Input.GetAxis("Horizontal");
      float z = Input.GetAxis("Vertical");
    //we have input we use input for math to move YOU
      Vector3 move = transform.right * x + transform.forward * z;
    //now lt`s move  
      Controller.Move(move * Speed * Time.deltaTime);
    }

    /////////////////////////////////////////////////
    void JumpAndGravity()
    {
     //isground Check
     isgrounded = Physics.CheckSphere(GroundChack.position, GroundDistance, GroundMask);
     //if yes and it is did`not zero it 
     if(isgrounded && velocity.y <0) { velocity.y = -2f; }//good you can jump now
     
      //if you press jump Key"space" + you are on ground = You jump
      if(Input.GetButtonDown("Jump") && isgrounded)
      {//some math
        velocity.y = Mathf.Sqrt(jumpheight * -2f * Gravity);
      }
       ///////////Gravity//////////////
      velocity.y += Gravity * Time.deltaTime;
      //yes Gravity are moveing YOU
      Controller.Move(velocity * Time.deltaTime); 
    }

    



}
