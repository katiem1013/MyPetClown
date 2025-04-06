using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    [Header("References")]
    public GameObject foodMenu;

    [Header("Menus")]
    public bool foodMenuActive = false;

    public void FeedMenu()
    {
        if (!foodMenuActive){foodMenuActive = true; foodMenu.active = true; }
        else if (foodMenuActive){ foodMenuActive = false; foodMenu.active = false; }
    }
}
