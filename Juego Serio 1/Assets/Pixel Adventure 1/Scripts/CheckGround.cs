using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    public static bool isGrounded;
    private void OnTriggerEnter2D(Collider2D collision){
      isGrounded = true;
    }
    private void GoTriggerExit2D(Collider2D collision){
      isGrounded = false;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
