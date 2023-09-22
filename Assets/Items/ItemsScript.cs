using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsScript : MonoBehaviour
{
    
}

public class KnifeItem
{
    public void KnifeItemUsed()
    {

    }
}

public class SwordItem
{
    public void SwordItemUsed()
    {

    }
}

public class SteakItem
{
    public void SteakItemUsed(string playerClass)
    {
        int playerMaxHP = PlayerPrefs.GetInt($"{playerClass}MaxHP");

        PlayerPrefs.SetInt($"{playerClass}MaxHP", playerMaxHP + 5);

        Debug.Log($"The item Steak was used and {playerClass}'s max HP was raised by 5");
    }
}

public class HealingPotionItem
{
    public void HealingPotionUsed(string playerClass)
    {
        int playerHP = PlayerPrefs.GetInt($"{playerClass}HP");
        int playerMaxHP = PlayerPrefs.GetInt($"{playerClass}MaxHP");

        if (playerHP >= playerMaxHP - 10)
        {
            PlayerPrefs.SetInt($"{playerClass}HP", playerMaxHP);
        }
        else
        {
            PlayerPrefs.SetInt($"{playerClass}HP", playerHP + 10);
        }

        Debug.Log($"{playerClass} Healed 10HP");
    }
}

public class ChestPlateItem
{
    public void ChestPlateUsed(string playerClass)
    {
        int playerInitialDefense = PlayerPrefs.GetInt($"{playerClass}InitialDefense");

        PlayerPrefs.SetInt($"{playerClass}InitialDefense", playerInitialDefense + 5);

        Debug.Log($"{playerClass}'s initial defense was raised by 5");
    }
}

public class HelmetItem
{
    public void HelmetUsed(string playerClass)
    {
        int playerInitialDefense = PlayerPrefs.GetInt($"{playerClass}InitialDefense");

        PlayerPrefs.SetInt($"{playerClass}InitialDefense", playerInitialDefense + 3);

        Debug.Log($"{playerClass}'s initial defense was raised by 3");
    }
}

public class LeggingsItem
{
    public void LeggingsUsed(string playerClass)
    {
        int playerInitialDefense = PlayerPrefs.GetInt($"{playerClass}InitialDefense");

        PlayerPrefs.SetInt($"{playerClass}InitialDefense", playerInitialDefense + 4);

        Debug.Log($"{playerClass}'s initial defense was raised by 4");
    }
}

