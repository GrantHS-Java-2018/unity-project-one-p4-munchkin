using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Race : DCard
{
   
    public RaceType race;
    
    public enum RaceType
    {
      Halfbreed,
      Elf,
      Halfling,
      Dwarf
    }

   

}