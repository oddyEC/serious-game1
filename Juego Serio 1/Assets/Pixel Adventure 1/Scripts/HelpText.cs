using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HelpText : MonoBehaviour
{
  public Text instructionText;
  public string Text = "ayuda";

  private void OnTriggerEnter2D(Collider2D collision){
    instructionText.text = Text;
  }
  private void OnTriggerExit2D(Collider2D collision){
    instructionText.text = "";
  }
}
