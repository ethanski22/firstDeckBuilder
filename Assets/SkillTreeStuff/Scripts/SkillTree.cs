using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTree : MonoBehaviour
{
    public static SkillTree skillTree;
    private void Awake() => skillTree = this;

    public int[] SkillLevels;
    public int[] SkillCaps;
    public string[] SkillNames;
    public string[] SkillDescription;

    public List<Skill> SkillList;
    public GameObject SkillHolder;

    public int SkillPoint;

    private void Start()
    {
        SkillPoint = 20;

        SkillLevels = new int[5];
        SkillCaps = new int[] {1, 2, 2, 5, 5 };

        SkillNames = new string[] {"Upgrade 1", "Upgrade 2", "Upgrade 3", "Upgrade 4", "Upgrade 5"};
        SkillDescription = new string[]
        {
            "Does something",
            "Does something else",
            "Does something cool",
            "Does something bad ass",
            "Does"
        };

        //foreach (var skill in SkillHolder.GetComponentInChildren<Skill>()) SkillList.Add(skill);
    }
}
