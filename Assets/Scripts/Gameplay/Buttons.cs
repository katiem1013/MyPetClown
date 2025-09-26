using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public static Buttons instance;

    [Header("References")]
    public GameObject foodMenu;
    public GameObject statsMenu;
    public GameObject wash;
    public GameObject sleep;
    public GameObject clown;
    public GameObject pauseMenu;
    public GameObject pracitce;

    [Header("Menus")]
    public bool foodMenuActive = false;
    public bool statsMenuActive = false;
    public bool washActive = false;
    public bool sleepActive = false;
    public bool pauseActive = false;


    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    public void FeedMenu()
    {
        SoundManagement.instance.UIClicking();

        if (!sleepActive)
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
       
    }

    public void StatsMenu()
    {
        SoundManagement.instance.UIClicking();

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

    public void Practice()
    {
        SoundManagement.instance.UIClicking();

        if (!sleepActive)
        {
            if (GameManager.instance.overallFeeling > 50 && GameManager.instance.sleep > (GameManager.instance.startSleep / 2) && GameManager.instance.health > (GameManager.instance.startHealth / 2) && GameManager.instance.hygiene > (GameManager.instance.startHygiene / 2) && GameManager.instance.hunger > (GameManager.instance.startHunger / 2) && GameManager.instance.happiness > (GameManager.instance.startHappiness / 2))
            {
                pracitce.SetActive(true);
            }

            else
            {
                GameManager.instance.SadClown();
            }
        }
    }

    public void Perform()
    {
        SoundManagement.instance.UIClicking();

        if (!sleepActive)
        {
            if (GameManager.instance.overallFeeling > 50 && GameManager.instance.sleep > (GameManager.instance.startSleep/2) && GameManager.instance.health > (GameManager.instance.startHealth / 2) && GameManager.instance.hygiene > (GameManager.instance.startHygiene / 2) && GameManager.instance.hunger > (GameManager.instance.startHunger / 2) && GameManager.instance.happiness > (GameManager.instance.startHappiness / 2))
            {
                float moneyGained = ((GameManager.instance.skill / (GameManager.instance.sleep + GameManager.instance.health + GameManager.instance.hygiene + GameManager.instance.hunger)) * GameManager.instance.happiness) * 5;
                GameManager.instance.money += Mathf.Ceil(moneyGained);
                GameManager.instance.sleep -= Mathf.Ceil(moneyGained);

                print(moneyGained);
            }

            else 
            {
                GameManager.instance.SadClown();
            }
        }
    }

    public void Wash()
    {
        SoundManagement.instance.UIClicking();

        if (!sleepActive)
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
    }

    public void Sleep()
    {
        SoundManagement.instance.UIClicking();

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

    public void PauseMenu()
    {
        SoundManagement.instance.UIClicking();

        if (!pauseActive)
        {
            pauseActive = true;
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
        }

        else if (pauseActive)
        {
            pauseActive = false;
            pauseMenu.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
