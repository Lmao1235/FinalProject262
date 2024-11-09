using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Solution
{
    public class InventoryExample : MonoBehaviour
    {
        public Inventory inventory;

        void Start()
        {
            // add item ... Potion, Sword, Potion
            inventory.AddItem("Potion");
            inventory.AddItem("Sword");
            inventory.AddItem("Potion");

            // display inventory
            inventory.ShowInventory();

            // use item
            inventory.UseItem("Potion");

            // display inventory
            inventory.ShowInventory();

            // [In-class Assignment] add item ... Soda x 10 and use 5 of them
            inventory.AddItem("Soda", 10);
            inventory.UseItem("Soda", 5);
            inventory.ShowInventory();
        }
    }

}