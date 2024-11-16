using Solution;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckItem : Identity
{
    
    public string Iron;
    public string Stick;
    

    public GameObject Stick1X;
    public GameObject Stick2X;
    public GameObject Iron1X;
    public GameObject Iron2X;

    public GameObject Stick1V;
    public GameObject Stick2V;
    public GameObject Iron1V;
    public GameObject Iron2V;
    public override void Obtain()
    {
        if (mapGenerator.player.inventory.numberOfItem(Iron) == 0)
        {
            Iron1X.SetActive(true);
            Iron2X.SetActive(true);
        }
        else if (mapGenerator.player.inventory.numberOfItem(Iron) == 1)
        {
            Iron1V.SetActive(true);
            Iron2X.SetActive(true);
        }
        else
        {
            Iron1V.SetActive(true);
            Iron2V.SetActive(true);
        }

        //_________________________________________________________________________________________________________________________________

        if (mapGenerator.player.inventory.numberOfItem(Stick) == 0)
        {
            Stick1X.SetActive(true);
            Stick2X.SetActive(true);
        }
        else if (mapGenerator.player.inventory.numberOfItem(Stick) == 1)
        {
            Stick1V.SetActive(true);
            Stick2X.SetActive(true);
        }
        else
        {
            Stick1V.SetActive(true);
            Stick2V.SetActive(true);
        }


    }
}
