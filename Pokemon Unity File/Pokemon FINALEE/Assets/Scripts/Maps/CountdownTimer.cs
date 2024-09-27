using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    public string levelToLoad;
    private float timer = 10f;
    private Text timerSeconds;

    void Start()
    {
        // Get the Text component attached to the same GameObject
        timerSeconds = GetComponent<Text>();
    }

    void Update()
    {
        // Decrease the timer based on the time elapsed since the last frame
        timer -= Time.deltaTime;

        // Update the UI text to show the remaining time, rounded to zero decimal places
        timerSeconds.text = timer.ToString("f0");

        // When the timer reaches zero or below, load the specified level
        if (timer <= 0)
        {
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
