using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

   private float Acceleration_X, Acceleration_Y;
   public float speed;
   public float deceleration = 0.5f;

   private Vector3 velocity;
   private Vector3 pos;

   private float Velocity_X, Velocity_Y;
   private float Position_X, Position_Y;

   private Rigidbody physics;

   private Vector2 input;

   // Use this for initialization
   void Start()
   {
      Acceleration_X = 20f;
      Acceleration_Y = 5f;
      velocity = new Vector3(0, 0, speed);
      Position_X = this.gameObject.transform.position.x;
      Position_Y = this.gameObject.transform.position.y;


      
      physics = GetComponent<Rigidbody>();
      physics.mass = 1;
      physics.drag = deceleration;
   }

   // Update is called once per frame
   void Update()
   {

   }

   public void FixedUpdate()
   {
      input.x = Input.GetAxis("Horizontal");
      input.y = Input.GetAxis("Vertical");

      velocity.x += input.x * Acceleration_X * Time.deltaTime;
      velocity.y += input.y * Acceleration_Y * Time.deltaTime;

      velocity *= Mathf.Pow(deceleration, Time.deltaTime);
      
      pos = transform.position + new Vector3(velocity.x, velocity.y, speed) * Time.deltaTime;
      transform.position = new Vector3(Mathf.Clamp(pos.x, -6, 6), Mathf.Clamp(pos.y, 0, 2.5f), pos.z);
    
   }
}

