using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwordMerchant : MonoBehaviour
{
    [SerializeField]
    private Text swordName; //A reference to the Text component of the NameText GameObject

    [SerializeField]
    private Text description; //A reference to the Text component of the DescriptionText GameObject

    [SerializeField]
    private Image icon; //A reference to the Image component of the Sword_Icon GameObject

    [SerializeField]
    private Text goldCost; //A reference to the Text component of the GoldText GameObject

    [SerializeField]
    private Text attackDamage; //A reference to the Text component of the AttackText GameObject

    public void UpdateDisplayUI (SwordData swordData)
    {

        swordName.text = swordData.SwordName;
        description.text = swordData.Description;
        icon.sprite = swordData.Icon;
        goldCost.text = swordData.GoldCost.ToString();
        attackDamage.text = swordData.AttackDamage.ToString();

    }
}
