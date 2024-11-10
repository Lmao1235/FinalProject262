using System.Collections;
using System.Collections.Generic;
using Solution;
using UnityEngine;

public class OOPTable : Identity
{
    public string Table;

    public override void Hit()
    {
        mapGenerator.player.inventory.AddItem(Table);
        Destroy(gameObject);
    }
}
