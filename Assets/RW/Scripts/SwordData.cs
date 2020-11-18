using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "New SwordData", menuName = "Sword Data", order = 51 )]
public class SwordData : ScriptableObject
{

    [SerializeField]
    private string swordName; // Name of sword

    [SerializeField]
    private string description; // Description of sword

    [SerializeField]
    private Sprite icon; // Sprites that holds the icon of sword

    [SerializeField]
    private int goldCost; // Gold cost for sword

    [SerializeField]
    private int attackDamage; // Damage for sword

    // Get data with public getter methods so other scripts can access the private fields.
    public string SwordName
    {
        get
        {
            return swordName;
        }
    }

    public string Description
    {
        get
        {
            return description;
        }
    }

    public Sprite Icon
    {
        get
        {
            return icon;
        }
    }

    public int GoldCost
    {
        get
        {
            return goldCost;
        }
    }

    public int AttackDamage
    {
        get
        {
            return attackDamage;
        }
    }

}