using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarbarianScript : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("HealthPoints", 100);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("H", 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public class Character : CharacterStats
    {
        public Character(string characterName, 
            string characterClass, 
            int characterHealth, 
            int characterDefence,
            int characterWealth,
            int characterPower,
            int characterPoison,
            bool isAlive,
            bool isAwake,
            int characterPosition) : 
            base(characterName, 
                characterClass, 
                characterHealth, 
                characterDefence,
                characterWealth,
                characterPower,
                characterPoison,
                isAlive,
                isAwake,
                characterPosition)
        {
            characterName = "Input Name";
            characterClass = "Barbarian";
            characterHealth = 100; // Change the health later to match each class
            characterDefence = 0;
            characterWealth = 100;
            characterPower = 5; // Cards will have a certain amount of power to be able to play
            characterPoison = 0;
            isAlive = true;
            isAwake = true;
            characterPosition = 0;
        }
    }


    
}