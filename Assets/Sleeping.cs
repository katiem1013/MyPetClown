using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sleeping : MonoBehaviour
{
    [Header("Stat Decrease")]
    public float sleepDecrease;

    [Header("Decrease Times")]
    public float sleepDecreaseTime;

    void OnDisable()
    {
        StopCoroutine("SleepIncrease");
        print("Awake");
    }

    void OnEnable()
    {
        StartCoroutine("SleepIncrease");
        print("Asleep");
    }

    IEnumerator SleepIncrease()
    {
        while (GameManager.instance.sleep > 0)
        {
            GameManager.instance.sleep += sleepDecrease;
            yield return new WaitForSeconds(sleepDecreaseTime);
        }
    }
}
