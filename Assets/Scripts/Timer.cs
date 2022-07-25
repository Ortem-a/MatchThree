using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float seconds = 61;
    public Text timerText;
    public GameObject gameOverPanel;
    public GameObject gameBoard;

    private float _timeLeft;
    private bool _timerOn;

    private void Awake()
    {
        gameOverPanel.SetActive(false);
    }

    private void Start()
    {
        _timeLeft = seconds;
        _timerOn = true;
    }

    private void Update()
    {
        if (_timerOn)
        {
            if (_timeLeft > 0)
            {
                _timeLeft -= Time.deltaTime;
                UpdateTimeText();
            }
            else
            {
                _timeLeft = seconds;
                _timerOn = false;
            }
        }
    }

    private void UpdateTimeText()
    {
        if (_timeLeft < 0)
        {
            Debug.Log("OUT OF TIME");
            gameOverPanel.SetActive(true);
            gameBoard.SetActive(false);
            _timeLeft = 0;
            _timerOn = false;
        }

        float minutes = Mathf.FloorToInt(_timeLeft / 60);
        float seconds = Mathf.FloorToInt(_timeLeft % 60);
        timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
