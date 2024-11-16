using Solution;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : Identity
{
    public string key;
    
    
    public override void Obtain()
    {
        mapGenerator.player.inventory.AddItem(key);
        Debug.Log("lol");
    }
}

