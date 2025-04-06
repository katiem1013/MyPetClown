using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    TimeManager timeManager;
    public TextMeshProUGUI display;
    public TextMeshProUGUI dayDisplay;

    // Start is called before the first frame update
    void Start()
    {
        timeManager = FindAnyObjectByType<TimeManager>();
        display = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        display.text = timeManager.Clock24Hours();
        dayDisplay.text = "Day " + GameManager.instance.day.ToString();
    }
}
