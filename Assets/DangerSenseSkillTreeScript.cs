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
    public int duration;
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
        duration = PlayerPrefs.GetInt("BarbarianDangerSenseCardDuration");
        cost = PlayerPrefs.GetInt("BarbarianDangerSenseCardCost");
        cardCostText.text = cost.ToString();
        cardDurationText.text = "Show Enemy Intentions";

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
        int cardCost = PlayerPrefs.GetInt("BarbarianDangerSenseCardCost");
        int cardDuration = PlayerPrefs.GetInt("BarbarianDangerSenseCardDuration");

        cardCostText.text = cardCost.ToString();
        cardDurationText.text = "Show Enemy Intentions";
    }

    public void BarbPlayerPrefs()
    {
        PlayerPrefs.SetInt("BarbarianDangerSenseCardCost", 4);
        PlayerPrefs.SetInt("BarbarianDangerSenseCardDuration", 0);
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
        cardCost = PlayerPrefs.GetInt("BarbarianDangerSenseCardCost");
        skillPoints = PlayerPrefs.GetInt("BarbarianSkillPoints");

        if (skillPoints >= 1)
        {
            skillPoints -= 1;
            cardCost -= 1;
            upgradeCost.interactable = false;
            upgradeCost2.interactable = true;
        }

        PlayerPrefs.SetInt("BarbarianDangerSenseCardCost", cardCost);
        PlayerPrefs.SetInt("BarbarianSkillPoints", skillPoints);
        UpdateSkillPoints();
        UpdateCardText();
    }

    public void UpgradeSecondCostButton()
    {
        cardCost = PlayerPrefs.GetInt("BarbarianDangerSenseCardCost");
        skillPoints = PlayerPrefs.GetInt("BarbarianSkillPoints");

        if (skillPoints >= 1)
        {
            skillPoints -= 1;
            cardCost -= 1;
            upgradeCost2.interactable = false;
            upgradeCost3.interactable = true;
        }

        PlayerPrefs.SetInt("BarbarianDangerSenseCardCost", cardCost);
        PlayerPrefs.SetInt("BarbarianSkillPoints", skillPoints);
        UpdateSkillPoints();
        UpdateCardText();
    }

    public void UpgradeThirdCostButton()
    {
        cardCost = PlayerPrefs.GetInt("BarbarianDangerSenseCardCost");
        skillPoints = PlayerPrefs.GetInt("BarbarianSkillPoints");

        if (skillPoints >= 1)
        {
            skillPoints -= 1;
            cardCost -= 1;
            upgradeCost3.interactable = false;
        }

        PlayerPrefs.SetInt("BarbarianDangerSenseCardCost", cardCost);
        PlayerPrefs.SetInt("BarbarianSkillPoints", skillPoints);
        UpdateSkillPoints();
        UpdateCardText();
        SpecialButtonActive();
    }

    public void UpgradeDurationButton()
    {
        cardDuration = PlayerPrefs.GetInt("BarbarianDangerSenseCardDuration");
        skillPoints = PlayerPrefs.GetInt("BarbarianSkillPoints");

        if (skillPoints >= 1)
        {
            skillPoints -= 1;
            cardDuration += 1;
            upgradeDuration.interactable = false;
            upgradeDuration2.interactable = true;
        }

        PlayerPrefs.SetInt("BarbarianDangerSenseCardDuration", cardDuration);
        PlayerPrefs.SetInt("BarbarianSkillPoints", skillPoints);
        UpdateSkillPoints();
        UpdateCardText();
    }

    public void UpgradeSecondDurationButton()
    {
        cardDuration = PlayerPrefs.GetInt("BarbarianDangerSenseCardDuration");
        skillPoints = PlayerPrefs.GetInt("BarbarianSkillPoints");

        if (skillPoints >= 1)
        {
            skillPoints -= 1;
            cardDuration += 1;
            upgradeDuration2.interactable = false;
            upgradeDuration3.interactable = true;
        }

        PlayerPrefs.SetInt("BarbarianDangerSenseCardDuration", cardDuration);
        PlayerPrefs.SetInt("BarbarianSkillPoints", skillPoints);
        UpdateSkillPoints();
        UpdateCardText();
    }

    public void UpgradeThirdDurationButton()
    {
        cardDuration = PlayerPrefs.GetInt("BarbarianDangerSenseCardDuration");
        skillPoints = PlayerPrefs.GetInt("BarbarianSkillPoints");

        if (skillPoints >= 1)
        {
            skillPoints -= 1;
            cardDuration += 1;
            upgradeDuration3.interactable = false;
        }

        PlayerPrefs.SetInt("BarbarianDangerSenseCardDuration", cardDuration);
        PlayerPrefs.SetInt("BarbarianSkillPoints", skillPoints);
        UpdateSkillPoints();
        UpdateCardText();
        SpecialButtonActive();
    }

    public void UpgradeButtonsIntractable()
    {
        cardDuration = PlayerPrefs.GetInt("BarbarianDangerSenseCardDuration");
        cardCost = PlayerPrefs.GetInt("BarbarianDangerSenseCardCost");

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
        if (PlayerPrefs.GetInt("BarbarianDangerSenseCardDuration") == 3 && PlayerPrefs.GetInt("BarbarianDangerSenseCardCost") == 1)
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
