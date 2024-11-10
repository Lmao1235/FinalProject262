using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Solution
{

    public class OOPExit : Identity
    {
        public string unlockKey;
        public GameObject YouWin;

        public void Start()
        {
            transform.position = new Vector3(7, 7, 0);
        }
        public override void Hit()
        {
            if (mapGenerator.player.inventory.numberOfItem(unlockKey) > 0)
            {
                Debug.Log("Exit unlocked");
                mapGenerator.player.enabled = false;
                YouWin.SetActive(true);
                Debug.Log("You win");
            }
            else
            {
                Debug.Log($"Exit locked, require key: {unlockKey}");
            }
        }
    }
}