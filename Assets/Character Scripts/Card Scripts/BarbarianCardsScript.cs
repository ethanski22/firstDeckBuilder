using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarbarianCardsScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}

public class HealCard
{
    public int healAmount = 5 + (PlayerPrefs.GetInt("BarbarianHealCardUpgrade") * 3);

    public void BarbarianHealCardUsed()
    {
        int HP = PlayerPrefs.GetInt("BarbarianHP");
        int afterHealHP;

        if (HP >= (PlayerPrefs.GetInt("BarbarianMaxHP") - healAmount))
        {
            afterHealHP = PlayerPrefs.GetInt("BarbarianMaxHP");
        }
        else
        {
            afterHealHP = HP + healAmount;
        }

        Debug.Log("Barbarian was healed " +  afterHealHP + " HP");
        PlayerPrefs.SetInt("BarbarianHP", afterHealHP);
    }
}

public class AttackCard
{
    public int attackDamage = 5 + (PlayerPrefs.GetInt("BarbarianAttackCardUpgrade") * 3);
}

public class DefendCard
{
    public int defendAmount = 5 + (PlayerPrefs.GetInt("BarbarianDefendCardUpgrade") * 3);

    public void BarbarianDefendCardUsed()
    {
        int currentDefense = PlayerPrefs.GetInt("BarbarianDefense");

        Debug.Log("Barbarian gained " + defendAmount + ", now his defense is at " + (currentDefense + defendAmount));
        PlayerPrefs.SetInt("BarbarianDefense", currentDefense + defendAmount);
    }
}

public class RageCard
{
    public int attackMultiplier = 2 + (PlayerPrefs.GetInt("BarbarianRageCardUpgrade") * 1);
}

public class ExtraAttackCard
{
    public int amountOfExtraAttacks = 1 + (PlayerPrefs.GetInt("BarbarianExtraAttackCardUpgrade") * 1);
}

public class DangerSenseCard
{
    public int levelOfPerception = 1 + (PlayerPrefs.GetInt("BarbarianDangerSenseCardUpgrade") * 1);
}

public class CriticalHitCard
{
    public int amountOfCriticalHits = 1 + (PlayerPrefs.GetInt("BarbarianCriticalHitCardUpgrade") * 1);
}

public class SlamCard
{
    public int attackDamage = 5 + (PlayerPrefs.GetInt("BarbarianSlamCardUpgrade") * 3);
}

public class PrimalInstinksCard
{
    public int amountOfBuffGain = 5 + (PlayerPrefs.GetInt("BarbarianPrimalInstinksCardUpgrade") * 3);
    public int amountOfDebuffInflicted = 5 + (PlayerPrefs.GetInt("BarbarianPrimalInstinksCardUpgrade") * 3);
}

public class FrenzyCard
{
    public int attackDamage = 5 + (PlayerPrefs.GetInt("BarbarianFrenzyCardUpgrade") * 3);
    public int amountOfAttacks = 2 + (PlayerPrefs.GetInt("BarbarianFrenzyCardUpgrade") * 1);
}

public class RetaliationCard
{
    public int retaliationDamage = 2 + (PlayerPrefs.GetInt("BarbarianRetaliationCardUpgrade") * 1);
}

public class AxeThrowCard
{
    public int attackDamage = 8 + (PlayerPrefs.GetInt("BarbarianAxeThrowCardUpgrade") * 4);
}