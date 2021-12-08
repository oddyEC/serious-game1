using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
  public float speed = 2f;
  public float jumpSpeed = 4f;
  Rigidbody2D body;
  Animator animations;

    void Start()
    {
      body = GetComponent<Rigidbody2D>();
      animations = GetComponent<Animator>();
    }
    private void FixedUpdate(){
      if(Input.GetKey("a") || Input.GetKey("left")){
        body.velocity = new Vector2(-speed, body.velocity.y);
        GetComponent<SpriteRenderer>().flipX = true;
        animations.SetBool("Run", true);
      }else if (Input.GetKey("d") || Input.GetKey("right")) {
        body.velocity = new Vector2(speed, body.velocity.y);
        GetComponent<SpriteRenderer>().flipX = false;
        animations.SetBool("Run", true);
      }else
      {
          body.velocity = new Vector2(0, body.velocity.y);
          animations.SetBool("Run", false);
      }
      if (CheckGround.isGrounded && Input.GetKey("space")) {
        body.velocity = new Vector2(body.velocity.x,jumpSpeed);
      }
    }

}
