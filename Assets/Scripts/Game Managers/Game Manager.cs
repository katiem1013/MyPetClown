using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("Care Stats")]
    public float happiness;
    public float health;
    public float hunger;
    public float hygiene;
    public float sleep;
    //public float social;  

    [Header("Career Stats")]
    public float popularity;
    public float skill;

    [Header("Game Stats")]
    public float money;
    public float currentTimeOfDay;
    public float day = 1;

    // starting stats
    private float startHappiness, startHealth, startHunger, startHygiene, startSleep;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }

    private void Start()
    {
        startHappiness = happiness;
        startHealth = health;
        startHunger = hunger;
        startHygiene = hygiene;
        startSleep = sleep;
    }

    private void Update()
    {
        if (happiness > startHappiness) {happiness = startHappiness;}
        if (health > startHealth) { health = startHealth; }
        if (hunger > startHunger) { hunger = startHunger; }
        if (hygiene > startHygiene) { hygiene = startHygiene; }
        if (sleep > startSleep) { sleep = startSleep; }

    }
}
