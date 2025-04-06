using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class FoodMenu : MonoBehaviour
{
    [Header("Reference")]
    public TextMeshProUGUI[] text;
    public TextMeshProUGUI foodText;
    public TextMeshProUGUI moneyText;

    [Header("Details")]
    public string food;
    public float price;
    public float hungerFill;
    public float happinessFill;

    public void Start()
    {
        text = GetComponentsInChildren<TextMeshProUGUI>();
        happinessFill = hungerFill / price * 10;
        hungerFill = price * 1.6f;
    }

    public void Update()
    {
        foreach (TextMeshProUGUI child in text)
        {
            if(child == text[0])
            {
                foodText = child;
                foodText.text = food;
            }

            if (child == text[1])
            {
                moneyText = child;
                moneyText.text = "$" + price.ToString();
            }
        }
    }

    public void BuyFood()
    {
        if (GameManager.instance.money < price)
        {
            print("Not Enough Funds");
        }

        else if (GameManager.instance.money >= price)
        {
            GameManager.instance.money -= price;
            GameManager.instance.hunger += hungerFill;
            GameManager.instance.happiness += happinessFill;
        }
    }
}
