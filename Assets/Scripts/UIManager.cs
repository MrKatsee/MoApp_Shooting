using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; } = null;

    private void Awake()
    {
        Instance = this;
    }

    public Text scoreText;

    public void SetScoreText(int score)
    {
        scoreText.text = score.ToString();
    }
}
