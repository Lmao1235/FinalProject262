using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.Data;

public class DatapresistanceManager : MonoBehaviour
{
    private Gamedata gamedata;
    private List<IDDatapersistance> datapersistancesObjects;
    public static DatapresistanceManager Instance { get; private set; }
    private void Awake()
    {
        if (Instance != null) 
        {
            Debug.LogError("Found more than one Data Presistance Manager in the Scence");
        }
        Instance = this;
    }
    private void Start()
    {
        this.datapersistancesObjects = FindAllDataPersistanceObject();
        LoadGame();
    }
    public void NewGame() 
    {
        this.gamedata=new Gamedata();
    }
    public void LoadGame() 
    {
        if (this.gamedata == null) 
        {
            Debug.Log("No Data was found. Intializing data to deffaults. ");
            NewGame();
        }
        foreach (IDDatapersistance datapersistanceObj in datapersistancesObjects) 
        {
            datapersistanceObj.LoadData(gamedata);
        }
    }
    public void SaveGame() 
    {
        foreach (IDDatapersistance datapersistanceObj in datapersistancesObjects)
        {
            datapersistanceObj.SaveData(ref gamedata);
        }
    }
    private void OnApplicationQuit()
    {
        SaveGame();
    }
    private List<IDDatapersistance> FindAllDataPersistanceObject() 
    {
        IEnumerable<IDDatapersistance> dataPersistancesObjects = FindObjectOfType<MonoBehaviour>().OfType<IDDatapersistance>();
        return new List<IDDatapersistance>(dataPersistancesObjects);
    }
}
