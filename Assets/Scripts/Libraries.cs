using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class Libraries : MonoBehaviour
{
  private Player player;
  private GameObject[] rObject;
  private int bruh;
  private int referenceNumber;
  private bool engageMonster;
  

//card identity int
    

    private void Start()
  {
      player = GameObject.Find("Player").GetComponent<Player>();
      rObject = GameObject.Find("Deck").GetComponent<Deck>().cardDeck;
      bruh = GameObject.Find("Deck").GetComponent<Deck>().topCard;
      referenceNumber = rObject[bruh].GetComponent<Card>().cardIdentity;
  }


  public bool engage()
  {
      engageMonster = false;

      if (referenceNumber == 14 || referenceNumber == 20 || referenceNumber == 31 ||
          referenceNumber == 32 || referenceNumber == 33 || referenceNumber == 34 ||
          referenceNumber == 35 || referenceNumber == 36)
      {
          switch (referenceNumber)
                {
                   case 14:
                       engageMonster = engageLawyer();
                       break;
                   case 20:
                       engageMonster = engageAmazon();
                       break;
                   case 31:
                       engageMonster = engageWrightBrothers();
                       break;
                   case 32:
                       engageMonster = engageWrightBrothers();
                       break;
                   case 33:
                       engageMonster = engageWrightBrothers();
                       break;
                   case 34:
                       engageMonster = engageBullrog();
                       break;
                   case 35:
                       engageMonster = engageBullrog();
                       break;
                   case 36:
                       engageMonster = engagePlutoniumDragon();
                       break;
                }
      }
      else
      {
          engageMonster = true;
      }
      return engageMonster;
  }
  
  //engage bools
  private bool engageLawyer()
  {
      if (player.playerClass == Player.PlayerClass.Thief)
      {
          return false;
      }
      else
      {
          return true;
      }
  }

  private bool engageAmazon()
  {
      if (player.playerSex == Player.Sex.Female)
      {
          return false;
      }
      else
      {
          return true;
      }
  }

  //same conditions as hippogriff and king tut
  private bool engageWrightBrothers()
  {
      if (player.levelRaw < 3)
      {
          return false;
      }
      else
      {
          return true;
      } 
  }
//same conditions as squidzilla
  private bool engageBullrog()
  {
      if (player.levelRaw < 4)
      {
          return false;
      }
      else
      {
          return true;
      } 
    
  }

  private bool engagePlutoniumDragon()
  {
      if (player.levelRaw < 5)
      {
          return false;
      }
      else
      {
          return true;
      }
  }
  
  //flee method
  public bool flee()
  {
      bool returnValue = false;


      return returnValue;
  }
  
  //flee bools
  
  
  
  
  

  
}
