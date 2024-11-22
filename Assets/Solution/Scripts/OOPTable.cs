using System.Collections;
using System.Collections.Generic;
using Solution;
using UnityEngine;

 public class OOPTable : Identity
 {
        public GameObject Craft;
        public GameObject CanvasCraft;


        public void Start()
        {
            //transform.position = new Vector3( 4, 3, 0);
        }

        public override void Hit()
        {
            CanvasCraft.SetActive(true);
        }



     

 }

