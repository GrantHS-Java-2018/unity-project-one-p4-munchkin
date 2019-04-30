using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{

    public enum Stage
    {
        loadout,
        kickdownDoor,
        engageEntity,
        flee,
        fight,
        deathOrLoot
                
    }

    public Stage stage;

    private void Awake()
    {
        stage = Stage.loadout;

    }

    private void Update()
    {
        
    }
}
