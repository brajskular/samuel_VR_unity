using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemCollector : MonoBehaviour
{
    public int score = 0;
    public int endScore = 3;
    public TMP_Text scoreText;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Treasure"))
        {
            Destroy(other.gameObject);
            score++;
            Debug.Log("Score: " + score);
        }
    }

    private void Update()
    {
        scoreText.text = "Score: " + score.ToString();
        if (score == endScore)
        {
            Application.Quit();
        }
    }
}
