using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarbarianScript : MonoBehaviour
{
    //
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
            int characterPosition) : 
            base(characterName, 
                characterClass, 
                characterHealth, 
                characterDefence,
                characterWealth,
                characterPower,
                characterPoison,
                isAlive,
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
            characterPosition = 0;
        }
    }


    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
}

