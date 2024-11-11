using System.Collections;
using System.Collections.Generic;
using Solution;
using UnityEngine;


    public class OOPTable : Identity
    {
        public GameObject Craft;
        public void Start()
        {
            transform.position = new Vector3( 4, 3, 0);
        }

        public void OnCollisionEnter2D(Collision2D Player)
        {
            Craft.SetActive(true);
        Debug.Log("LOL");
        }
        
    }

