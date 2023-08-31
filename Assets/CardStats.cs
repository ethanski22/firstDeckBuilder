using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardStats : MonoBehaviour
{
    // classes now

    public class CardBlueprint
    {
        public string cardName;
        public string cardDiscription;
        public string cardType;
        public int cardInt;
    }
    
    
    // I made the lists into strings because it was easier to code
    // If I want to change the values later convert to int then add/subtract
    List<List<string>> fighterCards = new List<List<string>>();
    List<List<string>> rangerCards = new List<List<string>>();
    List<List<string>> wizardCards = new List<List<string>>();
    List<List<string>> clericCards = new List<List<string>>();
    List<List<string>> monkCards = new List<List<string>>();
    List<List<string>> bardCards = new List<List<string>>();
    List<List<string>> druidCards = new List<List<string>>();
    List<List<string>> rogueCards = new List<List<string>>();
    List<List<string>> paladinCards = new List<List<string>>();
    List<List<string>> barbarianCards = new List<List<string>>();
    List<List<string>> warlockCards = new List<List<string>>();
    List<List<string>> sorcererCards = new List<List<string>>();
    List<List<string>> artificerCards = new List<List<string>>();

    // add the cards here
    public void AddFighterCards()
    {
        fighterCards.Add(new List<string> { "attack", "5" });
        CardStats attack = new CardStats();
    }      
            
    public void AddRangerCards()
    {      
           
    }      
            
    public void AddWizardCards()
    {      
           
    }      
            
    public void AddClericCards()
    {      
           
    }      
           
    public void AddMonkCards()
    {      
           
    }      
           
    public void AddBardCards()
    {      
           
    }      
           
    public void AddDruidCards()
    {      
           
    }      
           
    public void AddRogueCards()
    {      
           
    }      
           
    public void AddPaladinCards()
    {     
          
    }     
          
    public void AddBarbarianCards()
    {     
          
    }     
          
    public void AddWarlockCards()
    {     
          
    }     
          
    public void AddSorcererCards()
    {     
          
    }     
          
    public void AddArtificerCards()
    {

    }
}
