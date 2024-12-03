using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDDatapersistance 
{
    void LoadData(Gamedata gamedata);
    void SaveData(ref Gamedata gamedata);
}
