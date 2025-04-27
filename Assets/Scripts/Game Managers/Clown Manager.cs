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

    // Update is called once per frame
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
            yield return new WaitForSeconds(happinessDecreaseTime);
        }
    }

    IEnumerator HealthDecrease()
    {

        while (GameManager.instance.health > 0)
        {
            GameManager.instance.health -= healthDecrease;
            yield return new WaitForSeconds(healthDecreaseTime);
        }
    }

    IEnumerator HungerDecrease()
    {
        while (GameManager.instance.hunger > 0)
        {
            GameManager.instance.hunger -= hungerDecrease;
            yield return new WaitForSeconds(hungerDecreaseTime);
        }
    }

    IEnumerator HygieneDecrease()
    {
        while (GameManager.instance.hygiene > 0)
        {
            GameManager.instance.hygiene -= hygieneDecrease;
            yield return new WaitForSeconds(hygieneDecreaseTime);
        }
    }
    IEnumerator SleepDecrease()
    {
        while (GameManager.instance.sleep > 0 && Buttons.instance.sleepActive == true)
        {
            GameManager.instance.sleep -= sleepDecrease;
            yield return new WaitForSeconds(sleepDecreaseTime);
        }
    }
}
