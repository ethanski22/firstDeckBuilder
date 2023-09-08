using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
}

// This class is outside of the PlayerStats class because 
// if it is in the class the code will get bitchy
public class CharacterStats
{
    // Capital letters are known for public fields

    // When we create a character a name is required
    public string CharacterName { get; set; }

    // Doing this helps to not create conflicts in our code
    public CharacterStats(string characterName)
    {
        CharacterName = characterName;
    }
}

    