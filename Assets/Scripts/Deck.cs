using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public GameObject[] cardDeck;
    public Sprite[] allSprites;
    public GameObject cardPrefab;
    private GameObject mediumObj;
    private int topCard = 0;
    
    
    void Awake()
    {    
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

        for (int i = 0; i < 89; i++)
        {
            int ran = Random.Range(0, 88);
            mediumObj = cardDeck[ran];
            cardDeck[ran] = cardDeck[i];
            cardDeck[i] = mediumObj;


        }
           
        
      

    }





    public void draw()
    {  // int i = 0;
        //int i = Random.Range(0, 80);
       
        GameObject.Find("Core").GetComponent<GameLoop>().stage = GameLoop.Stage.engageEntity;
        GameObject.Find("Core").GetComponent<GameLoop>().engageEntity(cardDeck[topCard].GetComponent<Card>().sprite);
        topCard++;


    }

    public void assignDeck()
    {
        
        
        
        
    }

   
}
