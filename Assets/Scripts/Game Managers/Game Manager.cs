using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("Care Stats")]
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

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
    }
}
