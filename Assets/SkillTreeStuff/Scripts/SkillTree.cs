using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;
using System;

public class SkillTree : MonoBehaviour
{
    [SerializeField] private TMP_Text skillPointsText = null;
    public int skillPoints = 0;
    [SerializeField] private TMP_Text damageText = null;
    [SerializeField] private TMP_Text costText = null;
    [SerializeField] private Button baseButton = null;
    [SerializeField] private Button upgradeDamage = null;
    [SerializeField] private TMP_Text upgradeDamageText = null;
    public int damage;
    [SerializeField] private Button upgradeCost = null;
    [SerializeField] private TMP_Text upgradeCostText = null;
    public int cost;

    [SerializeField] private TMP_Text cardCostText = null;
    public int cardCost = 0;
    [SerializeField] private TMP_Text cardDamageText = null;
    public int cardDamage = 0;

    private void Start()
    {
        skillPointsText.text = PlayerPrefs.GetInt("BarbarianSkillPoints").ToString();
        damage = PlayerPrefs.GetInt("BarbarianUpgradeDamage");
        cost = PlayerPrefs.GetInt("BarbarianUpgradeCost");
        baseButton.enabled = false;

        skillPointsText.text = skillPoints.ToString();
        upgradeDamageText.text = skillPoints.ToString() + "/1";
        upgradeCostText.text = skillPoints.ToString() + "/1";
    }

    public void BarbPlayerPrefs()
    {
        PlayerPrefs.SetInt("BarbarianUpgradeDamage", 0);
        PlayerPrefs.SetInt("BarbarianUpgradeCost", 0);
        PlayerPrefs.SetInt("BarbarianAttackCost", 0);
        PlayerPrefs.SetInt("BarbarianAttackDamage", 0);
    }

     public void UpgradeCostButton()
    {
        cardCost = PlayerPrefs.GetInt("BarbarianAttackCost");

        if (Convert.ToInt32(skillPointsText.text) >= 1)
        {
            skillPoints -= 1;
            cardCost -= 1;

        }
    }

    public void UpgradeDamageButton()
    {
        cardDamage = PlayerPrefs.GetInt("BarbarianAttackDamage");

        if (Convert.ToInt32(skillPointsText.text) >= 1)
        {
            skillPoints -= 1;
            cardDamage += 1;
        }
    }
}
