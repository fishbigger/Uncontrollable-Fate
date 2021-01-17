using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIHandler : MonoBehaviour
{
    public TextMeshProUGUI deathText;
    public TextMeshProUGUI  timeText;

    public int deaths;
    public float time;

    void Start()
    {
        deaths = PlayerPrefs.GetInt("deaths", 0);
        time = PlayerPrefs.GetFloat("time", 0f);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        deathText.text = "Deaths: " + deaths;
        timeText.text = "Time: " + Mathf.Round(time * 10.0f) * 0.1f + "s";
    }
}
