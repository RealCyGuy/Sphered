using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    public TextMeshProUGUI playerOneScoreText;
    public TextMeshProUGUI playerTwoScoreText;

    void Start()
    {
        playerOneScoreText.text = Score.playerOneScore.ToString();
        playerTwoScoreText.text = Score.playerTwoScore.ToString();
    }
}
