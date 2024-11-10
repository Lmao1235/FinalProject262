using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    private int iron = 0;

    public TextMeshProUGUI irontext;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Iron")
        {
            iron++;
            irontext.text = iron.ToString();
            Debug.Log(iron);
            Destroy(other.gameObject);
        }
    }
}
