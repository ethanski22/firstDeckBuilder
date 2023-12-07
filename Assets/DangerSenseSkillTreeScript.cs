// Ignore Spelling: Prefs

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;
using System;

public class DangerSenseSkillTreeScript : MonoBehaviour
{
    [SerializeField] private TMP_Text skillPointsText = null;
    public int skillPoints = 0;
    [SerializeField] private Button upgradeDuration = null;
    [SerializeField] private Button upgradeDuration2 = null;
    [SerializeField] private Button upgradeDuration3 = null;
    [SerializeField] private TMP_Text upgradeDurationText = null;
    [SerializeField] private TMP_Text upgradeDuration2Text = null;
    [SerializeField] private TMP_Text upgradeDuration3Text = null;
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
    [SerializeField] private GameObject specialPanel = null;
    public int cost;

    [SerializeField] private TMP_Text cardCostText = null;
    public int cardCost = 0;
    [SerializeField] private TMP_Text cardDurationText = null;
    public int cardDuration = 0;

    private void Start()
    {
        skillPointsText.text = PlayerPrefs.GetInt("BarbarianSkillPoints").ToString();
        damage = PlayerPrefs.GetInt("BarbarianAxeThrowCardDamage");
        cost = PlayerPrefs.GetInt("BarbarianAxeThrowCardCost");
        cardCostText.text = cost.ToString();
        cardDurationText.text = "Deal " + damage.ToString() + " Damage To All Enemies";

        skillPointsText.text = skillPoints.ToString();

        upgradeDurationText.text = skillPoints.ToString() + "/1";
        upgradeDuration2Text.text = skillPoints.ToString() + "/1";
        upgradeDuration3Text.text = skillPoints.ToString() + "/1";

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
        upgradeDurationText.text = currentSkillPoints + "/1";
        upgradeDuration2Text.text = currentSkillPoints + "/1";
        upgradeDuration3Text.text = currentSkillPoints + "/1";
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

        upgradeDurationText.text = currentSkillPoints + "/1";
        upgradeDuration2Text.text = currentSkillPoints + "/1";
        upgradeDuration3Text.text = currentSkillPoints + "/1";
        upgradeCostText.text = currentSkillPoints + "/1";
        upgradeCost2Text.text = currentSkillPoints + "/1";
        upgradeCost3Text.text = currentSkillPoints + "/1";
        upgradeSpecialText.text = currentSkillPoints + "/3";
        skillPointsText.text = currentSkillPoints.ToString();
    }

    public void UpdateCardText()
    {
        int cardCost = PlayerPrefs.GetInt("BarbarianAxeThrowCardCost");
        int cardDuration = PlayerPrefs.GetInt("BarbarianAxeThrowCardDamage");

        cardCostText.text = cardCost.ToString();
        cardDurationText.text = "Deal " + cardDuration.ToString() + " Damage To All Enemies";
    }

    public void BarbPlayerPrefs()
    {
        PlayerPrefs.SetInt("BarbarianAxeThrowCardCost", 5);
        PlayerPrefs.SetInt("BarbarianAxeThrowCardDamage", 3);
    }

    public void SetPrefsButton()
    {
        BarbPlayerPrefs();
        UpdateCardText();
        SpecialButtonActive();
        UpgradeButtonsIntractable();
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
        UpdateSkillPoints();
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

    public void upgradeDurationButton()
    {
        cardDuration = PlayerPrefs.GetInt("BarbarianAxeThrowCardDamage");
        skillPoints = PlayerPrefs.GetInt("BarbarianSkillPoints");

        if (skillPoints >= 1)
        {
            skillPoints -= 1;
            cardDuration += 1;
            upgradeDuration.interactable = false;
            upgradeDuration2.interactable = true;
        }

        PlayerPrefs.SetInt("BarbarianAxeThrowCardDamage", cardDuration);
        PlayerPrefs.SetInt("BarbarianSkillPoints", skillPoints);
        UpdateSkillPoints();
        UpdateCardText();
    }

    public void UpgradeSecondDamageButton()
    {
        cardDuration = PlayerPrefs.GetInt("BarbarianAxeThrowCardDamage");
        skillPoints = PlayerPrefs.GetInt("BarbarianSkillPoints");

        if (skillPoints >= 1)
        {
            skillPoints -= 1;
            cardDuration += 1;
            upgradeDuration2.interactable = false;
            upgradeDuration3.interactable = true;
        }

        PlayerPrefs.SetInt("BarbarianAxeThrowCardDamage", cardDuration);
        PlayerPrefs.SetInt("BarbarianSkillPoints", skillPoints);
        UpdateSkillPoints();
        UpdateCardText();
    }

    public void UpgradeThirdDamageButton()
    {
        cardDuration = PlayerPrefs.GetInt("BarbarianAxeThrowCardDamage");
        skillPoints = PlayerPrefs.GetInt("BarbarianSkillPoints");

        if (skillPoints >= 1)
        {
            skillPoints -= 1;
            cardDuration += 1;
            upgradeDuration3.interactable = false;
        }

        PlayerPrefs.SetInt("BarbarianAxeThrowCardDamage", cardDuration);
        PlayerPrefs.SetInt("BarbarianSkillPoints", skillPoints);
        UpdateSkillPoints();
        UpdateCardText();
        SpecialButtonActive();
    }

    public void UpgradeButtonsIntractable()
    {
        cardDuration = PlayerPrefs.GetInt("BarbarianAxeThrowCardDamage");
        cardCost = PlayerPrefs.GetInt("BarbarianAxeThrowCardCost");

        if (cardDuration == 1)
        {
            upgradeDuration.interactable = false;
            upgradeDuration2.interactable = true;
        }

        if (cardDuration == 2)
        {
            upgradeDuration.interactable = false;
            upgradeDuration2.interactable = false;
            upgradeDuration3.interactable = true;
        }

        if (cardDuration == 3)
        {
            upgradeDuration.interactable = false;
            upgradeDuration2.interactable = false;
            upgradeDuration3.interactable = false;
        }

        if (cardCost == 3)
        {
            upgradeCost.interactable = false;
            upgradeCost2.interactable = true;
        }

        if (cardCost == 2)
        {
            upgradeCost.interactable = false;
            upgradeCost2.interactable = false;
            upgradeCost3.interactable = true;
        }

        if (cardCost == 1)
        {
            upgradeCost.interactable = false;
            upgradeCost2.interactable = false;
            upgradeCost3.interactable = false;
        }


    }

    public void SpecialButtonActive()
    {
        if (cardDurationText.text == "Deal 6 Damage To All Enemies" && cardCostText.text == "2")
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
            specialPanel.SetActive(true);
        }
    }
}
