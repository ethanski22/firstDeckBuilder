using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TestingShit", menuName = "My Game/Testing Shit")]
public class TestingShit : ScriptableObject
{

    public string characterName;
    public string characterClass;
    public int characterHealth;
    public int characterDefence;
    public int characterWealth;
    public int characterPower;
    public int characterPoison;
    public bool isAlive;
    public bool isAwake;
    public int characterPosition;
    public GameObject characterModel;
}
