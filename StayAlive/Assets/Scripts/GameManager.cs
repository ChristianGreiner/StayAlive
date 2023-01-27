using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject RoundPanel;
    public GameObject ScorePanel;
    private float timer = 0.0f;

    private int currentRound = 1;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GameStartCountdown());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator GameStartCountdown()
    {
        while (true)
        {
            GameStartCountdownCount();
            yield return new WaitForSeconds(1);
        }
    }
    void GameStartCountdownCount()
    {
        timer += 1;

        if (timer >= 3f)
            this.RoundPanel.SetActive(false);
    }
}
