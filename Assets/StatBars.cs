using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatBars : MonoBehaviour
{
    [Header("References")]
    public Image fillBar;
    public Sprite clownSprite;

    [Header("Colours")]
    public Color fullColour;
    public Color halfColour;
    public Color emptyColour;

    [Header("StatBar")]
    public bool health;
    public bool happiness;
    public bool hunger;
    public bool hygiene;
    public bool sleep;
    public bool skill;

    [Header("ClowmImages")]
    public Sprite baseClown;
    public Sprite happyClown, sadClown;

    // Start is called before the first frame update
    void Start()
    {
        fillBar = GetComponent<Image>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(health)
            fillBar.fillAmount = GameManager.instance.health / GameManager.instance.startHealth;

        if (happiness)
            fillBar.fillAmount = GameManager.instance.happiness / GameManager.instance.startHappiness;

        if (hunger)
            fillBar.fillAmount = GameManager.instance.hunger / GameManager.instance.startHunger;

        if (hygiene)
            fillBar.fillAmount = GameManager.instance.hygiene / GameManager.instance.startHygiene;

        if (sleep)
            fillBar.fillAmount = GameManager.instance.sleep / GameManager.instance.startSleep;

        if (skill)
            fillBar.fillAmount = GameManager.instance.skill;

        if (fillBar.fillAmount > .75)
            fillBar.color = fullColour;

        else if (fillBar.fillAmount < .75 && fillBar.fillAmount > .25)
            fillBar.color = halfColour;

        else 
            fillBar.color = emptyColour;
    }
}
