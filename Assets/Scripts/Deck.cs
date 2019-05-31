using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public Sprite[] allSprites;
    void Awake()
    {
        //Get the sliced card images as an array of 52 sprites
      
        allSprites = Resources.LoadAll<Sprite>("DoorCardSprites");
        

    }





    public void draw()
    {
        int i = Random.Range(0, 100);
        Card tempCard = allSprites[i];



    }

   
}
