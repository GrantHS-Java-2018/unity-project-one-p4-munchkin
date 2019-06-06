using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public enum PlayerClass
        {
            Thief,
            Cleric,
            Warrior,
            Wizard
        }

    public enum Sex
    {
        Male,
        Female
    }
    
    public int levelRaw;
    public int level;
    private int gold;
    private GameObject handOne;
    private GameObject handTwo;
    private GameObject headGear;
    private GameObject armor;
    private GameObject footGear;
    private bool big = false;
    public PlayerClass playerClass;
    public Sex playerSex;
    

    
    
    


    private void Awake()
    {
        
    }
}
