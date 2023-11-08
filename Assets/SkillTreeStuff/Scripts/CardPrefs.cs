using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardPrefs : MonoBehaviour
{
    private void Start()
    {
        PlayerPrefs.SetInt("BarbarianAttackCardDamage", 5);
        PlayerPrefs.SetInt("BarbarianAttackCardCost", 5);
    }
}
