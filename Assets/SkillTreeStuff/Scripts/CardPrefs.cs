using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardPrefs : MonoBehaviour
{
    private void Start()
    {
        PlayerPrefs.SetInt("BarbarianAttakcCardDamage", 5);
        PlayerPrefs.SetInt("BarbarianAttackCardCost", 5);
    }
}
