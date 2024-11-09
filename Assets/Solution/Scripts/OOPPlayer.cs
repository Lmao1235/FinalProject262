using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Solution
{
    public class OOPPlayer : Character
    {
        public Inventory inventory;
        public int Steps;

        public void Start()
        {
            PrintInfo();
            GetRemainEnergy();
        }

        public void Update()
        {
            if (Input.GetKeyDown(KeyCode.W) && Steps > -1)
            {
                Move(Vector2.up);
                Steps = Steps - 1 ;
            }
            if (Input.GetKeyDown(KeyCode.S) && Steps > -1)
            {
                Move(Vector2.down);
                Steps = Steps - 1;
            }
            if (Input.GetKeyDown(KeyCode.A) && Steps > -1)
            {
                Move(Vector2.left);
                Steps = Steps - 1;
            }
            if (Input.GetKeyDown(KeyCode.D) && Steps > -1)
            {
                Move(Vector2.right);
                Steps = Steps - 1;
            }

            if (Steps == -1) 
            {

            }
        }

        public void Attack(OOPEnemy _enemy)
        {
            _enemy.energy -= AttackPoint;
            Debug.Log(_enemy.name + " is energy " + _enemy.energy);
        }

        protected override void CheckDead()
        {
            base.CheckDead();
            if (energy <= 0)
            {
                Debug.Log("Player is Dead");
            }
        }

    }

}