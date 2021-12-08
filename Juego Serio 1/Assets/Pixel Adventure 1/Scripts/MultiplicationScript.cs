using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MultiplicationScript : MonoBehaviour
{
  public Text winLabel;

  private void OnTriggerEnter2D(Collider2D collision){
    if(collision.tag == "Correct"){
      winLabel.text = "Respuesta correcta";

    }
    if (collision.tag == "Incorrect"){
      winLabel.text = "Respuesta incorrecta";
    }
  }
  private void OnTriggerExit2D(Collider2D collision){
    if(collision.tag == "Incorrect"){
      winLabel.text = "";
    }
  }
}
