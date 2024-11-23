using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
                SceneManager.LoadSceneAsync(2);
            }
            else
            {
                Debug.Log($"Exit locked, require key: {unlockKey}");
            }
        }
    }
}