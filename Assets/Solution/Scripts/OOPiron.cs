using Solution;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OOPiron : Identity
{
    public string iron;

    public override void Hit()
    {
        mapGenerator.player.inventory.AddItem(iron);
        
        Destroy(gameObject);
    }
}
