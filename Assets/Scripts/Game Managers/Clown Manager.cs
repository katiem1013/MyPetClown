using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClownManager : MonoBehaviour
{
    [Header("Stat Decrease")]
    public float healthDecrease;
    public float hungerDecrease;
    public float hygieneDecrease;
    public float sleepDecrease;

    [Header("Decrease Times")]
    public float healthDecreaseTime;
    public float hungerDecreaseTime;
    public float hygieneDecreaseTime;
    public float sleepDecreaseTime;

    // Update is called once per frame
    void Start()
    {
        StartCoroutine("HealthDecrease");
        StartCoroutine("HungerDecrease");
        StartCoroutine("HygieneDecrease");
        StartCoroutine("SleepDecrease");
    }

    //coroutine decleration
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
        while (GameManager.instance.sleep > 0)
        {
            GameManager.instance.sleep -= sleepDecrease;
            yield return new WaitForSeconds(sleepDecreaseTime);
        }
    }
}
