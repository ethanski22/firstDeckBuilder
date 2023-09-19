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
    public int healAmount = 5;
}

public class AttackCard
{
    public int attackDamage = 5;
}

public class DefendCard
{
    public int defendAmount = 5;
}

public class RageCard
{
    public int attackMultiplier = 2;
}

public class ExtraAttackCard
{
    public int amountOfExtraAttacks = 1;
}

public class DangerSenseCard
{
    public int levelOfPerception = 1;
}

public class CriticalHitCard
{
    public int amountOfCriticalHits = 1;
}

public class SlamCard
{
    public int attackDamage = 5;
}

public class PrimalInstinksCard
{
    public int amountOfBuffGain = 5;
    public int amountOfDebuffInflicted = 5;
}

public class FrenzyCard
{
    public int attackDamage = 5;
    public int amountOfAttacks = 2;
}

public class RetaliationCard
{
    public int retaliationDamage = 2;
}

public class AxeThrowCard
{
    public int attackDamage = 8;
}