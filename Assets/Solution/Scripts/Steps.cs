using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Steps : MonoBehaviour
{
    private int Countdown = 10; //จำนวนเหรียญ

    public TextMeshProUGUI counttext;
    [SerializeField] private int SceneBuild;
    void Start()
    {
        counttext.text = "Steps: " + Countdown.ToString();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Countdown = Countdown - 1;
            counttext.text = "Steps: " + Countdown.ToString();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Countdown = Countdown - 1;
            counttext.text = "Steps: " + Countdown.ToString();
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Countdown = Countdown - 1;
            counttext.text = "Steps: " + Countdown.ToString();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Countdown = Countdown - 1;
            counttext.text = "Steps: " + Countdown.ToString();
        }

        if (Countdown < 0)
        {
            SceneManager.LoadScene(SceneBuild, LoadSceneMode.Single);
        }
    }
}
