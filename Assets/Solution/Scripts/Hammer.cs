using Solution;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hammer : Identity
{
    public string key;
    public string Iron;
    public string Stick;


    public override void Obtain()
    {
        if (mapGenerator.player.inventory.numberOfItem(Iron) > 1 && mapGenerator.player.inventory.numberOfItem(Stick) > 1)
        {
            mapGenerator.player.inventory.AddItem(key);
            mapGenerator.player.inventory.UseItem(Iron);
            mapGenerator.player.inventory.UseItem(Stick);
            Debug.Log("Go Exit");
            
        }
        else
        {
            Debug.Log("NOT ENOUGH");
        }

        
    }
}

