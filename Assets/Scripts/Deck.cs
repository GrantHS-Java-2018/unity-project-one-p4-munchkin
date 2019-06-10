using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Deck : MonoBehaviour
{
    //door deck
    public GameObject[] cardDeck;
    public Sprite[] allSprites;
    public GameObject cardPrefab;
    public GameObject mediumObj;
    public int topCard;
    
    //treasure deck
    public GameObject[] treasureDeck;
    public Sprite[] treasureSprites;
    public GameObject treasureMed;
    public int treasureTopCard;
   
    
    
    void Awake()
    {
        topCard = 0;
        //Get the sliced card images as an array of 52 sprites
        cardDeck = new GameObject[94];
        allSprites = Resources.LoadAll<Sprite>("DoorCardSprites");
        cardPrefab = Resources.Load<GameObject>("Prefabs/Card");
        //Debug.Log(allSprites.Length);
        for (int i = 0; i < 89; i++)
        {
            mediumObj = Instantiate(cardPrefab);
            //Instantiate(cardPrefab);
            mediumObj.GetComponent<Card>().cardIdentity = i;
            mediumObj.name = "Card" + i;
            mediumObj.GetComponent<Card>().sprite = allSprites[i];
            cardDeck[i] = mediumObj;
        }
//shuffle deck
        for (int i = 0; i < 80; i++)
        {
            int ran = Random.Range(0, 79);
            mediumObj = cardDeck[ran];
            cardDeck[ran] = cardDeck[i];
            cardDeck[i] = mediumObj;


        }

        setupTreasureDeck();
        shuffleTreasureDeck();
        




    }

    public void setupTreasureDeck()
    {
        treasureDeck = new GameObject[94];
        treasureTopCard = 0;
        treasureSprites = Resources.LoadAll<Sprite>("TreasureCardSprites");

        for (int i = 0; i < 70; i++)
        {
            treasureMed = Instantiate(cardPrefab);
            treasureMed.name = "TreasureCard" + i;
            treasureMed.GetComponent<Card>().sprite = treasureSprites[i];
        }
        
    }

    public void shuffleTreasureDeck()
    {
        for (int i = 0; i < 80; i++)
        {
            int ran = Random.Range(0, 79);
            treasureMed = treasureDeck[i];
            treasureDeck[i] = treasureDeck[ran];
            treasureDeck[ran] = treasureMed;
        }
        
    }





    public void draw()
    {  // int i = 0;
        //int i = Random.Range(0, 80);
       
        GameObject.Find("Core").GetComponent<GameLoop>().stage = GameLoop.Stage.engageEntity;
        GameObject.Find("Core").GetComponent<GameLoop>().engageEntity(cardDeck[topCard]);
        //topCard++;


    }

    public void treasureDraw(int num)
    {
        for (int i = 0; i < num; i++)
        {
            var cardName = "TreasureCard" + i;
            GameObject.Find(cardName).GetComponent<Image>().overrideSprite =
                treasureDeck[treasureTopCard].GetComponent<Card>().sprite;

            treasureTopCard++;



        }
        
        
        
    }
   
}
