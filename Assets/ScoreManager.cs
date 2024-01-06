using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    void Start()
    {
        if (scoreText == null)
        {
            Debug.LogError("ScoreText is not set in the inspector!"); // �G���[���R���\�[���ɕ\��
            return;
        }

        UpdateScoreUI();
    }

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        if (scoreText != null) // null �`�F�b�N��ǉ�
        {
            scoreText.text = "Score: " + score;
        }
    }
}

