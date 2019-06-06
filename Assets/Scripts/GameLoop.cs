using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLoop : MonoBehaviour
{
    //Deck Reference:
    
    
    private bool loadoutAccess = false;
    [SerializeField] private GameObject loadoutButton;
    public bool drawCard = false;
    
    

  
    
    

    public enum Stage
    {
        Loadout,
        kickdownDoor,
        engageEntity,
        flee,
        fight,
        loseOrLoot
                
    }

    public Stage stage;

    private void Awake()
    {
        drawCard = false;
        loadoutButton.SetActive(false);
        stage = Stage.Loadout;
        stageRun();

    }

    public void stageRun()
    {
        switch (stage)
        {
            case Stage.Loadout:
                loadout();
                break;
            case Stage.kickdownDoor:
                kickdownDoor();
                break;
            case Stage.engageEntity:
                //engageEntity();
                break;
            case Stage.flee:
                flee();
                break;
            case Stage.fight:
                fight();
                break;
            case Stage.loseOrLoot:
                loseOrLoot();
                break;
        }
    }

    private void loadout()
    {
        loadoutAccess = true;
        loadoutButton.SetActive(true);
        drawCard = true;


    }

    public void kickdownDoor()
    {
//disable loadout and draw card
        if (drawCard == true)
        {
          loadoutButton.SetActive(false);
          GameObject.Find("Deck").GetComponent<Deck>().draw();
          drawCard = false;
        }
        
        
    }
    
    public void engageEntity(GameObject drawnCard)
    {
        GameObject.Find("Deck").GetComponent<Image>().overrideSprite = drawnCard.GetComponent<Card>().sprite;
        GameObject.Find("Libraries").GetComponent<Libraries>().engage();
        GameObject.Find("Deck").GetComponent<Deck>().topCard++;
    }
    
    private void flee()
    {
        
    }
    
    private void fight()
    {
        
    }
    
    private void loseOrLoot()
    {
        
    }

    private void Update()
    {
        
    }
}
