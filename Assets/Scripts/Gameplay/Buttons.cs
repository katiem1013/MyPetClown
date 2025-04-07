using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    [Header("References")]
    public GameObject foodMenu;
    public GameObject statsMenu;
    public GameObject wash;
    public GameObject sleep;

    [Header("Menus")]
    public bool foodMenuActive = false;
    public bool statsMenuActive = false;
    public bool washActive = false;
    public bool sleepActive = false;

    public void FeedMenu()
    {
        if (!foodMenuActive)
        {
            foodMenuActive = true; 
            foodMenu.SetActive(true); 
        }
        else if (foodMenuActive)
        { 
            foodMenuActive = false;
            foodMenu.SetActive(false); 
        }
    }

    public void StatsMenu()
    {
        if (!statsMenuActive) 
        { 
            statsMenuActive = true; 
            statsMenu.SetActive(true); 
        }
        else if (statsMenuActive) 
        { 
            statsMenuActive = false; 
            statsMenu.SetActive(false);
        }
    }

    public void Perform()
    {
        if (GameManager.instance.sleep <= 0 || GameManager.instance.hygiene <= 0 || GameManager.instance.health <= 0 || GameManager.instance.hunger <= 0 || GameManager.instance.happiness <= 0)
        {
            float moneyGained = ((GameManager.instance.skill / (GameManager.instance.sleep + GameManager.instance.health + GameManager.instance.hygiene + GameManager.instance.hunger)) * GameManager.instance.happiness) * 5;
            GameManager.instance.money += Mathf.Ceil(moneyGained);
            GameManager.instance.sleep -= Mathf.Ceil(moneyGained);
        }
    }

    public void Wash()
    {
        if (!washActive)
        {
            washActive = true;
            wash.SetActive(true);
        }

        else if (washActive)
        {
            washActive = false;
            wash.SetActive(false);
        }
    }

    public void Sleep()
    {
        if (!sleepActive)
        {
            sleepActive = true;
            sleep.SetActive(true);
        }

        else if (sleepActive)
        {
            sleepActive = false; 
            sleep.SetActive(false);
        }
    }

   
}
