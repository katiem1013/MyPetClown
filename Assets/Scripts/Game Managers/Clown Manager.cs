using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClownManager : MonoBehaviour
{
    [Header("Stat Decrease")]
    public float happinessDecrease;
    public float healthDecrease;
    public float hungerDecrease;
    public float hygieneDecrease;
    public float sleepDecrease;

    [Header("Decrease Times")]
    public float happinessDecreaseTime;
    public float healthDecreaseTime;
    public float hungerDecreaseTime;
    public float hygieneDecreaseTime;
    public float sleepDecreaseTime;

    void Start()
    {
        StartCoroutine("HappinessDecrease");
        StartCoroutine("HealthDecrease");
        StartCoroutine("HungerDecrease");
        StartCoroutine("HygieneDecrease");
        StartCoroutine("SleepDecrease");
    }


    //coroutine decleration
    IEnumerator HappinessDecrease()
    {

        while (GameManager.instance.happiness > 0)
        {
            GameManager.instance.happiness -= happinessDecrease;
            if (GameManager.instance.happiness < (GameManager.instance.startHappiness / 2))
                GameManager.instance.SadClown(); 

            yield return new WaitForSeconds(happinessDecreaseTime);

        }
    }

    IEnumerator HealthDecrease()
    {

        while (GameManager.instance.health > 0)
        {
            GameManager.instance.health -= healthDecrease;
            if (GameManager.instance.health < (GameManager.instance.startHealth / 2))
                GameManager.instance.SadClown();

            yield return new WaitForSeconds(healthDecreaseTime);

        }
    }

    IEnumerator HungerDecrease()
    {
        while (GameManager.instance.hunger > 0)
        {
            GameManager.instance.hunger -= hungerDecrease;
            if (GameManager.instance.hunger < (GameManager.instance.startHunger / 2))
                GameManager.instance.SadClown();

            yield return new WaitForSeconds(hungerDecreaseTime);
        }
    }

    IEnumerator HygieneDecrease()
    {
        while (GameManager.instance.hygiene > 0)
        {  
            GameManager.instance.hygiene -= hygieneDecrease;
            if (GameManager.instance.hygiene < (GameManager.instance.startHygiene / 2))
                GameManager.instance.SadClown(); 
           
            yield return new WaitForSeconds(hygieneDecreaseTime);

           
        }
    }
    IEnumerator SleepDecrease()
    {
        while (GameManager.instance.sleep > 0 && Buttons.instance.sleepActive == true)
        {
            GameManager.instance.sleep -= sleepDecrease;
            if (GameManager.instance.sleep < (GameManager.instance.startSleep / 2))
                GameManager.instance.SadClown();

            yield return new WaitForSeconds(sleepDecreaseTime);
        }
    }
}
