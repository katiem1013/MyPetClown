using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sleeping : MonoBehaviour
{
    [Header("References")]
    public Animator animator;
    public GameObject night;

    [Header("Stat Decrease")]
    public float sleepDecrease;

    [Header("Decrease Times")]
    public float sleepDecreaseTime;

    private void Update()
    {
        if (GameManager.instance.sleep == GameManager.instance.startSleep)
            gameObject.SetActive(false);

    }

    void OnDisable()
    {
        StopCoroutine("SleepIncrease");
        print("Awake");
        night.SetActive(false);
        animator.enabled = false;
    }

    void OnEnable()
    {
        StartCoroutine("SleepIncrease");
        print("Asleep");
        night.SetActive(true);
        animator.enabled = true;
    }

    IEnumerator SleepIncrease()
    {
        while (GameManager.instance.sleep < GameManager.instance.startSleep)
        {
            GameManager.instance.sleep += sleepDecrease;
            yield return new WaitForSeconds(sleepDecreaseTime);
        }
    }
}
