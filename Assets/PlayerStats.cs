using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStats", menuName = "My Game/Player Stats")]
public class PlayerStats : ScriptableObject
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

// This class is outside of the PlayerStats class because 
// if it is in the class the code will get bitchy
public class CharacterStats
{
    // Capital letters are known for public fields

    // When we create a character a name is required
    public string CharacterName { get; set; }
    public string CharacterClass { get; set; }
    public int CharacterHealth { get; set; }
    public int CharacterDefence { get; set; }
    public int CharacterWealth { get; set; }
    public int CharacterPower { get; set; } // Amount of cards that player could play
    public int CharacterPoison { get; set; } 
    public bool IsAlive { get; set; }
    public bool IsAwake { get; set; }
    public int CharacterPosition { get; set; } // Use this to figure out where to put the character on the screen

    // Doing this helps to not create conflicts in our code
    public CharacterStats(string characterName, 
        string characterClass, 
        int characterHealth, 
        int characterDefence,
        int characterWealth,
        int characterPower,
        int characterPoison,
        bool isAlive,
        bool isAwake,
        int characterPosition)
    {
        CharacterName = characterName;
        CharacterClass = characterClass;
        CharacterHealth = characterHealth;
        CharacterDefence = characterDefence;
        CharacterWealth = characterWealth;
        CharacterPower = characterPower;
        CharacterPoison = characterPoison;
        IsAlive = isAlive;
        IsAwake = isAwake;
        CharacterPosition = characterPosition;
    }
}

