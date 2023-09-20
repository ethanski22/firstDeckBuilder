using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarbarianScript : MonoBehaviour
{
    
    void SetStats()
    {
        PlayerPrefs.SetInt("BarbarianHP", 100);
        PlayerPrefs.SetInt("BarbarianDefence", 0);
        PlayerPrefs.SetInt("BarbarianPoison", 0);
        PlayerPrefs.SetInt("Money", 0);
        PlayerPrefs.Save();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}