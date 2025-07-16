using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float countdown;
    public TMP_Text countdownText;
    public BoxManager boxManager;

    public PowerUp[] powerUps;

    private void Start()
    {
        SkipBoxes();
    }

    private void Update()
    {
        countdown -= Time.deltaTime;

        if (countdown < 0)
        {
            SkipBoxes();
            countdown = 3;
        }

        countdownText.text = "Countdown: " + countdown.ToString("f1");
    }

    public void SkipBoxes()
    {
        boxManager.SkipRound();
    }

    public void AddRandomPowerUp()
    {
        int index = Random.Range(0, powerUps.Length);
        powerUps[index].AddPowerUp();
    }
}