using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TestingShit", menuName = "My Game/Enemy Stats")]
public class NewBehaviourScript : ScriptableObject
{
    public string characterName;
    public string characterClass;
    public int characterHealth;
    public int characterDefence;
    public int characterPoison;
    public bool isAlive;
    public bool isAwake;
    public int characterPosition;
    public GameObject characterModel;
}
