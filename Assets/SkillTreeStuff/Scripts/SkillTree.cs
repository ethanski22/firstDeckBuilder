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
    [SerializeField] private Button upgradeDamage = null;
    [SerializeField] private Button upgradeDamage2 = null;
    [SerializeField] private Button upgradeDamage3 = null;
    [SerializeField] private TMP_Text upgradeDamageText = null;
    [SerializeField] private TMP_Text upgradeDamage2Text = null;
    [SerializeField] private TMP_Text upgradeDamage3Text = null;
    public int damage;
    [SerializeField] private Button upgradeCost = null;
    [SerializeField] private Button upgradeCost2 = null;
    [SerializeField] private Button upgradeCost3 = null;
    [SerializeField] private TMP_Text upgradeCostText = null;
    [SerializeField] private TMP_Text upgradeCost2Text = null;
    [SerializeField] private TMP_Text upgradeCost3Text = null;
    [SerializeField] private Button upgradeSpecial = null;
    [SerializeField] private TMP_Text upgradeSpecialText = null;
    [SerializeField] private GameObject specialGameObject = null;
    [SerializeField] private GameObject special = null;
    public int cost;

    [SerializeField] private TMP_Text cardCostText = null;
    public int cardCost = 0;
    [SerializeField] private TMP_Text cardDamageText = null;
    public int cardDamage = 0;

    private void Start()
    {
        skillPointsText.text = PlayerPrefs.GetInt("BarbarianSkillPoints").ToString();
        damage = PlayerPrefs.GetInt("BarbarianAxeThrowCardDamage");
        cost = PlayerPrefs.GetInt("BarbarianAxeThrowCardCost");
        cardCostText.text = cost.ToString();
        cardDamageText.text = "Deal " + damage.ToString() + " Damage";

        skillPointsText.text = skillPoints.ToString();

        upgradeDamageText.text = skillPoints.ToString() + "/1";
        upgradeDamage2Text.text = skillPoints.ToString() + "/1";
        upgradeDamage3Text.text = skillPoints.ToString() + "/1";

        upgradeCostText.text = skillPoints.ToString() + "/1";
        upgradeCost2Text.text = skillPoints.ToString() + "/1";
        upgradeCost3Text.text = skillPoints.ToString() + "/1";

        upgradeSpecialText.text = skillPoints.ToString() + "/3";

        UpdateSkillPoints();
        SpecialButtonActive();
        UpgradeButtonsIntractable();
    }

    public void GiveSkillPointButton()
    {
        int currentSkillPoints = PlayerPrefs.GetInt("BarbarianSkillPoints");

        currentSkillPoints++;
        upgradeDamageText.text = currentSkillPoints + "/1";
        upgradeDamage2Text.text = currentSkillPoints + "/1";
        upgradeDamage3Text.text = currentSkillPoints + "/1";
        upgradeCostText.text = currentSkillPoints + "/1";
        upgradeCost2Text.text = currentSkillPoints + "/1";
        upgradeCost3Text.text = currentSkillPoints + "/1";
        upgradeSpecialText.text = currentSkillPoints + "/3";
        skillPointsText.text = currentSkillPoints.ToString();

        PlayerPrefs.SetInt("BarbarianSkillPoints", currentSkillPoints);
    }

    public void UpdateSkillPoints()
    {
        int currentSkillPoints = PlayerPrefs.GetInt("BarbarianSkillPoints");

        upgradeDamageText.text = currentSkillPoints + "/1";
        upgradeDamage2Text.text = currentSkillPoints + "/1";
        upgradeDamage3Text.text = currentSkillPoints + "/1";
        upgradeCostText.text = currentSkillPoints + "/1";
        upgradeCost2Text.text = currentSkillPoints + "/1";
        upgradeCost3Text.text = currentSkillPoints + "/1";
        upgradeSpecialText.text = currentSkillPoints + "/3";
        skillPointsText.text = currentSkillPoints.ToString();
    }

    public void UpdateCardText()
    {
        int cardCost = PlayerPrefs.GetInt("BarbarianAxeThrowCardCost");
        int cardDamage = PlayerPrefs.GetInt("BarbarianAxeThrowCardDamage");

        cardCostText.text = cardCost.ToString();
        cardDamageText.text = "Deal " + cardDamage.ToString() + " Damage";
    }

    public void BarbPlayerPrefs()
    {
        PlayerPrefs.SetInt("BarbarianAxeThrowCardCost", 5);
        PlayerPrefs.SetInt("BarbarianAxeThrowCardDamage", 5);
    }

    public void SetPrefsButton()
    {
        BarbPlayerPrefs();
        UpdateCardText();
        SpecialButtonActive();
    }

     public void UpgradeCostButton()
    {
        cardCost = PlayerPrefs.GetInt("BarbarianAxeThrowCardCost");
        skillPoints = PlayerPrefs.GetInt("BarbarianSkillPoints");

        if (skillPoints >= 1)
        {
            skillPoints -= 1;
            cardCost -= 1;
            upgradeCost.interactable = false;
            upgradeCost2.interactable = true;
        }

        PlayerPrefs.SetInt("BarbarianAxeThrowCardCost", cardCost);
        PlayerPrefs.SetInt("BarbarianSkillPoints", skillPoints);
        UpdateSkillPoints() ;
        UpdateCardText();
    }

    public void UpgradeSecondCostButton()
    {
        cardCost = PlayerPrefs.GetInt("BarbarianAxeThrowCardCost");
        skillPoints = PlayerPrefs.GetInt("BarbarianSkillPoints");

        if (skillPoints >= 1)
        {
            skillPoints -= 1;
            cardCost -= 1;
            upgradeCost2.interactable = false;
            upgradeCost3.interactable = true;
        }

        PlayerPrefs.SetInt("BarbarianAxeThrowCardCost", cardCost);
        PlayerPrefs.SetInt("BarbarianSkillPoints", skillPoints);
        UpdateSkillPoints();
        UpdateCardText();
    }
    
    public void UpgradeThirdCostButton()
    {
        cardCost = PlayerPrefs.GetInt("BarbarianAxeThrowCardCost");
        skillPoints = PlayerPrefs.GetInt("BarbarianSkillPoints");

        if (skillPoints >= 1)
        {
            skillPoints -= 1;
            cardCost -= 1;
            upgradeCost3.interactable = false;
        }

        PlayerPrefs.SetInt("BarbarianAxeThrowCardCost", cardCost);
        PlayerPrefs.SetInt("BarbarianSkillPoints", skillPoints);
        UpdateSkillPoints();
        UpdateCardText();
        SpecialButtonActive();
    }

    public void UpgradeDamageButton()
    {
        cardDamage = PlayerPrefs.GetInt("BarbarianAxeThrowCardDamage");
        skillPoints = PlayerPrefs.GetInt("BarbarianSkillPoints");

        if (skillPoints >= 1)
        {
            skillPoints -= 1;
            cardDamage += 1;
            upgradeDamage.interactable = false;
            upgradeDamage2.interactable = true;
        }

        PlayerPrefs.SetInt("BarbarianAxeThrowCardDamage", cardDamage);
        PlayerPrefs.SetInt("BarbarianSkillPoints", skillPoints);
        UpdateSkillPoints();
        UpdateCardText();
    }

    public void UpgradeSecondDamageButton()
    {
        cardDamage = PlayerPrefs.GetInt("BarbarianAxeThrowCardDamage");
        skillPoints = PlayerPrefs.GetInt("BarbarianSkillPoints");

        if (skillPoints >= 1)
        {
            skillPoints -= 1;
            cardDamage += 1;
            upgradeDamage2.interactable = false;
            upgradeDamage3.interactable = true;
        }

        PlayerPrefs.SetInt("BarbarianAxeThrowCardDamage", cardDamage);
        PlayerPrefs.SetInt("BarbarianSkillPoints", skillPoints);
        UpdateSkillPoints();
        UpdateCardText();
    }

    public void UpgradeThirdDamageButton()
    {
        cardDamage = PlayerPrefs.GetInt("BarbarianAxeThrowCardDamage");
        skillPoints = PlayerPrefs.GetInt("BarbarianSkillPoints");

        if (skillPoints >= 1)
        {
            skillPoints -= 1;
            cardDamage += 1;
            upgradeDamage3.interactable = false;
        }

        PlayerPrefs.SetInt("BarbarianAxeThrowCardDamage", cardDamage);
        PlayerPrefs.SetInt("BarbarianSkillPoints", skillPoints);
        UpdateSkillPoints();
        UpdateCardText();
        SpecialButtonActive();
    }

    public void UpgradeButtonsIntractable()
    {
        cardDamage = PlayerPrefs.GetInt("BarbarianAxeThrowCardDamage");
        cardCost = PlayerPrefs.GetInt("BarbarianAxeThrowCardCost");

        if (cardDamage == 6)
        {
            upgradeDamage.interactable = false;
            upgradeDamage2.interactable = true;
        }

        if (cardDamage == 7)
        {
            upgradeDamage.interactable = false;
            upgradeDamage2.interactable = false;
            upgradeDamage3.interactable = true;
        }
        
        if (cardDamage == 8)
        {
            upgradeDamage.interactable = false;
            upgradeDamage2.interactable = false;
            upgradeDamage3.interactable = false;
        }

        if (cardCost == 4)
        {
            upgradeCost.interactable = false;
            upgradeCost2.interactable = true;
        }

        if (cardCost == 3)
        {
            upgradeCost.interactable = false;
            upgradeCost2.interactable = false;
            upgradeCost3.interactable = true;
        }

        if (cardCost == 2)
        {
            upgradeCost.interactable = false;
            upgradeCost2.interactable = false;
            upgradeCost3.interactable = false;
        }


    }

    public void SpecialButtonActive()
    {
        if (cardDamageText.text == "Deal 8 Damage" && cardCostText.text == "2")
        {
            specialGameObject.SetActive(true);
        }
        else
        {
            specialGameObject.SetActive(false);
        }
    }

    public void UpgradeSpecialButton()
    {
        skillPoints = PlayerPrefs.GetInt("BarbarianSkillPoints");

        if (skillPoints >= 3)
        {
            skillPoints -= 3;
            upgradeSpecial.interactable = false;
            special.SetActive(true);
        }
    }
}
