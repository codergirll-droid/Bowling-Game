using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    GameObject[] pins;
    int pinCount;
    public Text pinCountTxt;
    public Text timer;
    public Text score;
    [SerializeField] float time = 60f;
    [SerializeField] GameObject timesUpPanel;
    [SerializeField] GameObject WonPanel;
    [SerializeField] GameObject startPanel;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        startPanel.SetActive(true);

        timesUpPanel.SetActive(false);
        WonPanel.SetActive(false);

        pins = GameObject.FindGameObjectsWithTag("pin");
    }

    // Update is called once per frame
    void Update()
    {
        pins = GameObject.FindGameObjectsWithTag("pin");
        pinCount = pins.Length;
        pinCountTxt.text = "Pins: " + pinCount.ToString();

        time -= Time.deltaTime;
        timer.text = "Time: " + time.ToString("0") + "s";

        score.text = "Your score: " + (50 - pinCount).ToString();

        if(time <= 0)
        {
            Time.timeScale = 0;
            timesUpPanel.SetActive(true);
        }

        if(pinCount <= 0)
        {
            Time.timeScale = 0;
            WonPanel.SetActive(true);
        }

    }
}
