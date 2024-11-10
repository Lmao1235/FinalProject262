using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEditor.Timeline.TimelinePlaybackControls;

namespace Solution
{

    public class OOPItemPotion : Identity
    {
        private int Irons = 0; //จำนวนเหรียญ

        public TextMeshProUGUI irontext;

        public int healPoint = 10;
        public bool isBonues;

        private void Start()
        {
            isBonues = Random.Range(0, 100) < 20 ? true : false;
            if (isBonues)
            {
                GetComponent<SpriteRenderer>().color = Color.blue;
            }
        }
        public override void Hit()
        {
            if (isBonues)
            {
                mapGenerator.player.Heal(healPoint, isBonues);
                Debug.Log("You got " + Name + " Bonues : " + healPoint * 2);
            }
            else
            {
                mapGenerator.player.Heal(healPoint);
                Debug.Log("You got " + Name + " : " + healPoint);
            }

            

            mapGenerator.mapdata[positionX, positionY] = 0;
            Destroy(gameObject);
        }
    }
}