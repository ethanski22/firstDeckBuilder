// Ignore Spelling: Prefs

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
        damage = PlayerPrefs.GetInt("BarbarianAttakcCardDamage");
        cost = PlayerPrefs.GetInt("BarbarianAttackCardCost");
        baseButton.enabled = false;
        cardCostText.text = cost.ToString();
        cardDamageText.text = "Deal " + damage.ToString() + " Damage";

        skillPointsText.text = skillPoints.ToString();
        upgradeDamageText.text = skillPoints.ToString() + "/1";
        upgradeCostText.text = skillPoints.ToString() + "/1";

        UpdateSkillPoints();
    }

    public void GiveSkillPointButton()
    {
        int currentSkillPoints = PlayerPrefs.GetInt("BarbarianSkillPoints");

        currentSkillPoints++;
        upgradeDamageText.text = currentSkillPoints + "/1";
        upgradeCostText.text = currentSkillPoints + "/1";
        skillPointsText.text = currentSkillPoints.ToString();

        PlayerPrefs.SetInt("BarbarianSkillPoints", currentSkillPoints);
    }

    public void UpdateSkillPoints()
    {
        int currentSkillPoints = PlayerPrefs.GetInt("BarbarianSkillPoints");

        upgradeDamageText.text = currentSkillPoints + "/1";
        upgradeCostText.text = currentSkillPoints + "/1";
        skillPointsText.text = currentSkillPoints.ToString();
    }

    public void BarbPlayerPrefs()
    {
        PlayerPrefs.SetInt("BarbarianUpgradeDamage", 0);
        PlayerPrefs.SetInt("BarbarianUpgradeCost", 0);
        PlayerPrefs.SetInt("BarbarianAttackCardCost", 5);
        PlayerPrefs.SetInt("BarbarianAttakcCardDamage", 5);
    }

    public void SetPrefsButton()
    {
        BarbPlayerPrefs();
    }

     public void UpgradeCostButton()
    {
        cardCost = PlayerPrefs.GetInt("BarbarianAttackCardCost");
        skillPoints = PlayerPrefs.GetInt("BarbarianSkillPoints");

        if (skillPoints >= 1)
        {
            skillPoints -= 1;
            cardCost -= 1;
            upgradeCost.interactable = false;
        }

        PlayerPrefs.SetInt("BarbarianSkillPoints", skillPoints);
        UpdateSkillPoints() ;
    }

    public void UpgradeDamageButton()
    {
        cardDamage = PlayerPrefs.GetInt("BarbarianAttakcCardDamage");
        skillPoints = PlayerPrefs.GetInt("BarbarianSkillPoints");

        if (skillPoints >= 1)
        {
            skillPoints -= 1;
            cardDamage += 1;
            upgradeDamage.interactable = false;
        }

        PlayerPrefs.SetInt("BarbarianSkillPoints", skillPoints);
        UpdateSkillPoints();
    }
}
