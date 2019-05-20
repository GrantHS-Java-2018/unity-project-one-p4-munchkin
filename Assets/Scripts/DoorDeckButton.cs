using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;

public class DoorDeckButton : MonoBehaviour
{


 public void execute()
 {
  
  GameObject.Find("Core").GetComponent<GameLoop>().stage = GameLoop.Stage.kickdownDoor;
  GameObject.Find("Core").GetComponent<GameLoop>().stageRun();
  
  


 }   
    
}
