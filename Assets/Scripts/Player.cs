using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int levelRaw;
    private int level;
    private int gold;
    private GameObject handOne;
    private GameObject handTwo;
    private GameObject headGear;
    private GameObject armor;
    private GameObject footGear;
    private bool big = false;
    
    

    public enum Class
    {
        Thief,
        Cleric,
        Warrior,
        Wizard
    }


    private void Awake()
    {
        throw new System.NotImplementedException();
    }
}
