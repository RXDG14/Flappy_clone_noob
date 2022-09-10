using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score = 0;
    [SerializeField] Text text;

    private void Start()
    {
        text.text = score.ToString();
    }
    public void UpdateScore()
    {
        score++;
        text.text = score.ToString();
    }
}
