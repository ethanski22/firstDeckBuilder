using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarbarianScript : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("BarbarianHP", 100);
        PlayerPrefs.SetInt("Money", 0);
        PlayerPrefs.Save();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}