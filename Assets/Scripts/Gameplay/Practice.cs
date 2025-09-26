using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Practice : MonoBehaviour
{
    public GameObject circlePrefab; // The circle prefab to be spawned
    public GameObject currentCircle; // The current circle in the scene

    public GameObject canvas;
    public float currentRaceTime = 15f;

    public float score = 0;
    public TextMeshProUGUI scoreText;

    void Awake()
    {
        canvas.SetActive(false);
        score = 0;
        SpawnCircle(); // Spawn the first circle at the start
    }

    private void OnDisable()
    {
        GameManager.instance.skill += score / 2;
        canvas.SetActive(true);
    }

    private void Update()
    {
        currentRaceTime -= Time.deltaTime;

        if (currentRaceTime < 0)
        {
            gameObject.SetActive(false);
            Destroy(currentCircle);
        }
            
        scoreText.text = score.ToString();
    }

    // A simple way to spawn a new circle (e.g., on a button click or touch)
    public void SpawnCircle()
    {
        if (circlePrefab != null)
        {
            Vector2 spawnPosition = Camera.main.ViewportToWorldPoint(new Vector2(Random.value, Random.value));

            currentCircle = Instantiate(circlePrefab, spawnPosition, Quaternion.identity);
            
            float scale = Random.Range(0.1f, 1f);

            currentCircle.transform.localScale = new Vector3(scale, scale, 100);

        }
    }

    // This function will be called when the circle is clicked
    public void OnCircleClicked()
    {
        if (currentCircle != null)
        {
            score += 1;
            Destroy(currentCircle); // Destroy the current circle
            SpawnCircle();          // Spawn a new one
        }
    }
}
