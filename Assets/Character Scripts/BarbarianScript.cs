using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarbarianScript : MonoBehaviour
{
    
    void SetStats()
    {
        PlayerPrefs.SetInt("BarbarianHP", 100);
        PlayerPrefs.SetInt("BarbarianMaxHP", 100);
        PlayerPrefs.SetInt("BarbarianMP", 10);
        PlayerPrefs.SetInt("BarbarianInitialDefense", 0);
        PlayerPrefs.SetInt("BarbarianDefense", 0);
        PlayerPrefs.SetInt("BarbarianPoison", 0);
        PlayerPrefs.SetInt("Money", 0);
        PlayerPrefs.Save();
    }

    void BarbarianCardUpgrades()
    {
        PlayerPrefs.SetInt("BarbarianHealCardUpgrade", 0);
        PlayerPrefs.SetInt("BarbarianAttackCardUpgrade", 0);
        PlayerPrefs.SetInt("BarbarianDefendCardUpgrade", 0);
        PlayerPrefs.SetInt("BarbarianRageCardUpgrade", 0);
        PlayerPrefs.SetInt("BarbarianExtraAttackCardUpgrade", 0);
        PlayerPrefs.SetInt("BarbarianDangerSenseCardUpgrade", 0);
        PlayerPrefs.SetInt("BarbarianCriticalHitCardUpgrade", 0);
        PlayerPrefs.SetInt("BarbarianSlamCardUpgrade", 0);
        PlayerPrefs.SetInt("BarbarianPrimalInstinksCardUpgrade", 0);
        PlayerPrefs.SetInt("BarbarianFrenzyCardUpgrade", 0);
        PlayerPrefs.SetInt("BarbarianRetaliationCardUpgrade", 0);
        PlayerPrefs.SetInt("BarbarianAxeThrowCardUpgrade", 0);
        PlayerPrefs.Save();
    }

    void AwakeBarbarian()
    {
        SetStats();
        BarbarianCardUpgrades();
    }


    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("BarbarianMP")){
            Debug.Log("Barbarian has already been created");
        }
        else
        {
            AwakeBarbarian();
            Debug.Log("Barbarian will be created");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}