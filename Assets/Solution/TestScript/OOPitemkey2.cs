using Solution;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OOPitemkey2 : Identity
{
    public string key;

    public override void Hit()
    {
        mapGenerator.player.inventory.AddItem(key);
        Destroy(gameObject);
    }
}
