using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    [Header("Clock Settings")]
    public const int hoursInDay = 24;
    public const int minutesInHour = 60;
    public float dayDuration = 30f;

    [Header("Time Tracking")]
    float totalTimePassed = 0;
    bool newDay = false;

    // Update is called once per frame
    void Update()
    {
        totalTimePassed += Time.deltaTime;
        GameManager.instance.currentTimeOfDay = totalTimePassed % dayDuration;

        if (Mathf.FloorToInt(GetHour()).ToString("00") + ":" + Mathf.FloorToInt(GetMinutes()).ToString("00") == "00:01" && !newDay)
        {
            newDay = true;
            GameManager.instance.day += 1;
        }

        if (Mathf.FloorToInt(GetHour()).ToString("00") + ":" + Mathf.FloorToInt(GetMinutes()).ToString("00") == "00:02" && newDay)
        {
            newDay = false;
        }

    }

    public float GetHour()
    {
        return GameManager.instance.currentTimeOfDay * hoursInDay / dayDuration;
    }

    public float GetMinutes()
    {
        return (GameManager.instance.currentTimeOfDay * hoursInDay * minutesInHour / dayDuration)%minutesInHour;
    }

    public string Clock24Hours()
    {
        return Mathf.FloorToInt(GetHour()).ToString("00") + ":" + Mathf.FloorToInt(GetMinutes()).ToString("00");
    }


}
