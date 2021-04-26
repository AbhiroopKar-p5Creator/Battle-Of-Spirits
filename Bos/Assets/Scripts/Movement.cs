using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
 #region Declarations

 [Tooltip("Helps In Setting Up The Snappy Movement")]
 public float power;

 private Vector3 snappyMovement;

 private float xInput;
 private float zInput;
 private int steps;

 private bool atTenx;
 private bool atThirtyx;
 private bool atFiftyx;
 private bool atEightyx;
 private bool atHundredx;

 private bool atTeny;
 private bool atThirtyy;
 private bool atFiftyy;
 private bool atEightyy;
 private bool atHundredy;

 private bool enter = false; 


 [Space] [Tooltip("The Main Speed Of Which The Movement Is Made(Speed Can Be Adjusted Relative To It)")]
 public float masterSpeed;

 public Physics physicsEngine;

 [Space] [Tooltip("Maximum Steps After Key Is Realeased")] [Range(0, 7)]
 public int maxSteps;

 [Space] [Range(0f, 100f)] public float Ten;
 [Range(0f, 100f)] public float Thirty;
 [Range(0f, 100f)] public float Fifty;
 [Range(0f, 100f)] public float Eighty;
 [Range(0f, 100f)] public float Hundred;

 #endregion


 void FixedUpdate()
 {
  xInput = Input.GetAxis("Horizontal") * power;
  zInput = Input.GetAxis("Vertical") * power;
 }

 public Vector3 ApplySnappyMovement(float x, float z)
 {
  Vector3 movement = new Vector3(0, 0, 0);

  if (atTenx == true)
  {
   movement.x += masterSpeed * 30f;
  }

  return movement;
 }


 private float percentage(float number, float total)
 {
  float percentage = number / total * 100f;
  return percentage;
 }

 public void Equations(float x, float z)
 {
  float percentX = percentage(x, 100f);
  float percentY = percentage(z, 100f);

  if (percentX <= 10f)
  {
   atTenx = true;
  }
  else
  {
   atTenx = false;
  }

  if (percentX <= 30f && percentX > 10f)
  {
   atThirtyx = true;
  }
  else
  {
   atThirtyx = false;
  }

  if (percentX <= 50f && percentX > 30f)
  {
   atFiftyx = true;
  }
  else
  {
   atFiftyx = false;
  }

  if (percentX <= 80f && percentX > 50f)
  {
   atEightyx = true;
  }
  else
  {
   atEightyx = false;
  }

  if (percentX <= 100f && percentX > 80f)
  {
   atHundredx = true;
  }
  else
  {
   atHundredx = false;
  }

  if (percentY <= 10f)
  {
   atTeny = true;
  }
  else
  {
   atTeny = false;
  }

  if (percentY <= 30f && percentX > 10f)
  {
   atThirtyy = true;
  }
  else
  {
   atThirtyy = false;
  }

  if (percentY <= 50f && percentX > 30f)
  {
   atFiftyy = true;
  }
  else
  {
   atFiftyy = false;
  }

  if (percentY <= 80f && percentX > 50f)
  {
   atEightyy = true;
  }
  else
  {
   atEightyy = false;
  }

  if (percentX <= 100f && percentX > 80f)
  {
   atHundredy = true;
  }
  else
  {
   atEightyy = false;
  }
 }

 private float AddOnce(float number,float  adder)
 {
  if (enter == true)
  { 
   number += adder;
   enter = true;
  }
  return number;
  
 }
 
}
