using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public Card[] cardDeck;
    public Sprite[] allSprites;
    public GameObject cardPrefab;
    
    
    void Awake()
    {    
        //Get the sliced card images as an array of 52 sprites
        cardDeck = new Card[94];
        allSprites = Resources.LoadAll<Sprite>("DoorCardSprites");
        cardPrefab = Resources.Load<GameObject>("Prefabs/Card");
        //Debug.Log(allSprites.Length);
        for (int i = 0; i < 89; i++)
        {
            Instantiate(cardPrefab);
        }
           
        
        

    }





    public void draw()
    {  // int i = 0;
        int i = Random.Range(0, 93);
        Sprite tempCard = cardDeck[i].sprite;
        GameObject.Find("Core").GetComponent<GameLoop>().stage = GameLoop.Stage.engageEntity;
        GameObject.Find("Core").GetComponent<GameLoop>().engageEntity(tempCard);


    }

    public void assignDeck()
    {
        
        
        
        
    }

   
}
