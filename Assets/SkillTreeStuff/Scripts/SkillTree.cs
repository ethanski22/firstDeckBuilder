using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SkillTree : MonoBehaviour
{
    [SerializeField] private TMP_Text skillPointsText = null;
    [SerializeField] private TMP_Text damageText = null;
    [SerializeField] private TMP_Text costText = null;
    [SerializeField] private Button upgradeDamage = null;
    [SerializeField] private Button upgradeCost = null;

    private void Start()
    {
        skillPointsText.text = PlayerPrefs.GetInt("BarbarianSkillPoints").ToString();
        damageText.text = PlayerPrefs.GetInt("BarbarianUpgradeDamage").ToString();
        costText.text = PlayerPrefs.GetInt("BarbarianUpgradeCost").ToString();

    }

    public void BarbAttackCard()
    {

    }

    public void BarbPlayerPrefs()
    {
        PlayerPrefs.SetInt("BarbarianUpgradeDamage", 0);
        PlayerPrefs.SetInt("BarbarianUpgradeCost", 0);
    }
}
