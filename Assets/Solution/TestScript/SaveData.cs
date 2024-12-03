using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    [System.Serializable]
    public class Savedata
    {
        public int playerLevel;
        public float playerHealth;
        public Vector3 playerPosition;
    }
}
