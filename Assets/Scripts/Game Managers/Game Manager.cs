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

    [Header("Starting Care Stats")]
    public float startHappiness;
    public float startHealth;
    public float startHunger;
    public float startHygiene;
    public float startSleep;

    [Header("Clowm Images")]
    public SpriteRenderer clownSprite;
    public Sprite baseClown,happyClown, sadClown;

    [Header("Clowm Dirt")]
    public GameObject clownDirt1;
    public GameObject clownDirt2;
    public GameObject clownDirt3;   
    public GameObject clownDirt4;


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
        StatBlock();

        ClownImages();
        ClownDirt();
    }

    public void ClownImages()
    {
        float averageClownFeeling = (happiness + health + hunger + hygiene + sleep) / 5;

        if (averageClownFeeling > 95f)
            clownSprite.sprite = happyClown;
        else if (averageClownFeeling > 50f)
            clownSprite.sprite = baseClown;
        else
            clownSprite.sprite = sadClown;
    }

    public void ClownDirt()
    {
        if(hygiene < 90)
        {
            clownDirt1.SetActive(true);
            clownDirt2.SetActive(false);
            clownDirt3.SetActive(false);
            clownDirt4.SetActive(false);
        }

        if (hygiene < 75)
        {
            clownDirt1.SetActive(true);
            clownDirt2.SetActive(true);
            clownDirt3.SetActive(false);
            clownDirt4.SetActive(false);
        }

        if (hygiene < 50)
        {
            clownDirt1.SetActive(true);
            clownDirt2.SetActive(true);
            clownDirt3.SetActive(true);
            clownDirt4.SetActive(false);
        }

        if (hygiene < 25)
        {
            clownDirt1.SetActive(true);
            clownDirt2.SetActive(true);
            clownDirt3.SetActive(true);
            clownDirt4.SetActive(true);
        }

        else
        {
            clownDirt1.SetActive(false);
            clownDirt2.SetActive(false);
            clownDirt3.SetActive(false);
            clownDirt4.SetActive(false);
        }
    }

    public void StatBlock()
    {
        // stops stats going below 0
        if (happiness < 0) { happiness = 0; }
        if (health < 0) { health = 0; }
        if (hunger < 0) { hunger = 0; }
        if (hygiene < 0) { hygiene = 0; }
        if (sleep < 0) { sleep = 0; }

        // stops stats going above their max
        if (happiness > startHappiness) { happiness = startHappiness; }
        if (health > startHealth) { health = startHealth; }
        if (hunger > startHunger) { hunger = startHunger; }
        if (hygiene > startHygiene) { hygiene = startHygiene; }
        if (sleep > startSleep) { sleep = startSleep; }
    }
}
